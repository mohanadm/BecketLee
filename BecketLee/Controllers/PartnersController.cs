﻿using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BecketLee.Data;
using BecketLee.Models;
using BecketLee.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;

namespace BecketLee.Controllers.Web
{
    public class PartnersController : BaseController
    {
        private readonly IHostingEnvironment _environment;
        private IPartnerRepository _repository;
        private readonly ILogger<PartnersController> _logger;
        private PartnerMenuViewModel _menuModel;

        public PartnersController( IHostingEnvironment environment, 
            IPartnerRepository repository, 
            ILogger<PartnersController> logger)
        {
            _environment = environment;
            _repository = repository;
            _logger = logger;
            _menuModel = new PartnerMenuViewModel(repository);
        }

        public IActionResult Index()
        {
            try
            {
                _logger.LogInformation( "Getting all the partner information." );
                return View( _repository.GetAllPartners() );
            }
            catch (Exception exception)
            {
                _logger.LogError( $"Failed to get partners in controller.\n" + exception.Message );
                return RedirectToAction( "Error", "Home" );
            }
        }

        public IActionResult ManagePartners()
        {
            try
            {
                _logger.LogInformation( "Getting all the partner information." );
                return View( GetPartnersModel(-1) );
            }
            catch (Exception exception)
            {
                _logger.LogError( $"Failed to get partners in controller.\n" + exception.Message );
                return RedirectToAction( "Error", "Home" );
            }
        }

        public IActionResult ConfirmPartnerDeletion( int deleteId )
        {
            var model = GetPartnersModel( deleteId );
            return View( "ManagePartners", model );
        }

        public PartnersViewModel GetPartnersModel( int deleteId )
        {
            var model = new PartnersViewModel
            {
                Partners = _repository.GetAllPartners()
            };

            if (deleteId > 0)
            {
                var deleteEvent = model.Partners.FirstOrDefault(e => e.PartnerId == deleteId);
                if (deleteEvent != null)
                {
                    var delModel = new DeletionModel()
                    {
                        Controller = "Partners",
                        Action = "DeletePartnerBio",
                        DeleteId = deleteId,
                        Heading = "Confirm Deletion",
                        Item = "partner biography",
                        Title = deleteEvent.PartnerName
                    };
                    model.DeletionModel = delModel;
                }
            }
            return model;
        }

        [HttpGet]
        public IActionResult PartnerBio( string id )
        {    
            return View( _repository.GetPartnerByName( id ) ?? new PartnerViewModel() );
        }

        [HttpGet]
        [Authorize]
        public IActionResult EditPartnerBio( string id )
        {
            if (!User.IsInRole("Administrator") &&
                !User.IsInRole("BioEditor"))
            {
                return RedirectToAction( "UnauthorizedView", "Home" );
            }
            return View( _repository.GetPartnerByName( id ) ?? new PartnerViewModel() );        
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>EditPartnerBio(PartnerViewModel model)
        {
            if (ModelState.IsValid)
            {
                await UploadFile(model);
                await _repository.UpdatePartnerAsync(model);
                return RedirectToAction("ManagePartners", "Partners");
            }
            var bio = _repository.GetPartnerByName( model.PartnerName ) ?? new PartnerViewModel();
            bio.PartnerId = model.PartnerId;
            bio.PartnerName = model.PartnerName;
            bio.BiographyHtml = model.BiographyHtml;
            return View( bio );
        }


        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        private async Task<bool> UploadFile(PartnerViewModel model)
        {
            var file = model.File;
            if ( file == null ) return false;
        
            if ( file.Length > 0 )
            {
                var uploadName = ContentDispositionHeaderValue.Parse( file.ContentDisposition ).FileName.Trim();
                var fileName = uploadName.Substring( uploadName.LastIndexOf( '\\' ) + 1 );
                var streamName = Path.Combine( _environment.WebRootPath, "image\\BioImage", fileName );
                using (var filestream = System.IO.File.Create(streamName))
                {
                    if( model.IsImage( file ) )
                    {
                        model.FileUrl = @"/image/BioImage" + $@"/{fileName}";
                        model.FileName = fileName;
                        model.File = file;

                        await file.CopyToAsync( filestream );
                        await filestream.FlushAsync();
                    }
                    else
                        return false;
                }
            }
            return true;
        }


        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePartnerBio( string deleteId)
        {
            if (!string.IsNullOrEmpty( deleteId ))
            {
                string name = _repository.GetPartnerNameById( Convert.ToInt32( deleteId ) );
                var partnerBio = _repository.GetPartnerByName( name );
                if (partnerBio != null)
                {
                    _repository.DeletePartnerBio( partnerBio );
                }
            }
            return RedirectToAction( "ManagePartners" );
        }

        public override PartnerMenuViewModel MenuModel
        {
            get { return _menuModel; }
            set { _menuModel = value; }
        }
    }
}