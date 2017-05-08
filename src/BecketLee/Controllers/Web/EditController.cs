using System.IO;
using System.Threading.Tasks;
using BecketLee.Data;
using BecketLee.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;

public class EditController : Controller
{
    private readonly IHostingEnvironment _environment;
    private BecketLeeContext _context;

    public EditController( IHostingEnvironment environment, BecketLeeContext context )
    {
        _environment = environment;
        _context = context;
    }

    public IActionResult EditBio()
    {
        var data = _context.PartnerBiographies;
        var model = new PartnerViewModel();
        return View( model );
    }

    [HttpPost]
    public async Task<IActionResult>EditBio(PartnerViewModel model)
    {
        await UploadFile( model );

        return View(model);
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