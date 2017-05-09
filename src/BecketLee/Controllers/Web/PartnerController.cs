using System;
using System.IO;
using System.Threading.Tasks;
using BecketLee.Data;
using BecketLee.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;

public class PartnerController : Controller
{
    private readonly IHostingEnvironment _environment;
    private BecketLeeRepository _repository;
    private readonly ILogger<PartnerController> _logger;

    public PartnerController( IHostingEnvironment environment, 
        BecketLeeRepository repository, 
        ILogger<PartnerController> logger)
    {
        _environment = environment;
        _repository = repository;
        _logger = logger;
    }

    public IActionResult Partners()
    {
        try
        {
            _logger.LogInformation( "Getting all the partner information." );
            return View( _repository.GetAllPartners() );
        }
        catch (Exception exception)
        {
            _logger.LogError( $"Failed to get partners in controller.\n" + exception.Message );
            return Redirect( "/error.html" );
        }
    }

    [HttpGet]
    public IActionResult Bio( string id )
    {    
        var data = _repository.GetPartnerByName( id );
        if (data == null)
            data = new PartnerViewModel();
        return View( data );
    }

    [HttpGet]
    public IActionResult EditBio( string id )
    {
        var data = _repository.GetPartnerByName( id );
        if( data == null ) data = new PartnerViewModel();
        return View( data );
    }

    [HttpPost]
    public async Task<IActionResult>EditBio(PartnerViewModel model)
    {
        await UploadFile( model );
        model = _repository.UpdatePartner( model );
        return RedirectToAction( "Partners" );
    }


    [HttpPost]
    public async Task<bool> UploadFile(PartnerViewModel model)
    {
        var file = model.File;
        if ( file == null ) return false;
        
        if ( file.Length > 0 )
        {
            var uploadName = ContentDispositionHeaderValue.Parse( file.ContentDisposition ).FileName.Trim( '"' );
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


}