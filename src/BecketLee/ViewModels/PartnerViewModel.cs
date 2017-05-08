using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Http;

namespace BecketLee.ViewModels
{
    public class PartnerViewModel
    {
        [Key]
        public int PartnerId { get; set; }

        [Required]
        public string PartnerName { get; set; }

        [Required]
        public string BiographyHtml { get; set; }

        public IFormFile File { get; set; }
        public string FileUrl { get; set; }
        public string FileName { get; set; }

        #region Helper Functions

        private const int ImageMinimumBytes = 512;

        public bool IsImage( IFormFile postedFile )
        {
            //-------------------------------------------
            //  Check the image mime types
            //-------------------------------------------
            if( postedFile.ContentType.ToLower() != "image/jpg" &&
                postedFile.ContentType.ToLower() != "image/jpeg" &&
                postedFile.ContentType.ToLower() != "image/pjpeg" &&
                postedFile.ContentType.ToLower() != "image/gif" &&
                postedFile.ContentType.ToLower() != "image/x-png" &&
                postedFile.ContentType.ToLower() != "image/png" )
            {
                return false;
            }

            //-------------------------------------------
            //  Check the image extension
            //-------------------------------------------
            if( Path.GetExtension( postedFile.FileName ).ToLower() != ".jpg"
                && Path.GetExtension( postedFile.FileName ).ToLower() != ".png"
                && Path.GetExtension( postedFile.FileName ).ToLower() != ".gif"
                && Path.GetExtension( postedFile.FileName ).ToLower() != ".jpeg" )
            {
                return false;
            }


            //-------------------------------------------
            //  Attempt to read the file and check the first bytes
            //-------------------------------------------
            using (var fileStream = postedFile.OpenReadStream())
            {
                try
                {


                    if( !fileStream.CanRead )
                    {
                        return false;
                    }

                    if( fileStream.Length < ImageMinimumBytes )
                    {
                        return false;
                    }

                    byte[] buffer = new byte[512];
                    fileStream.Read( buffer, 0, 512 );
                    string content = System.Text.Encoding.UTF8.GetString( buffer );
                    if( Regex.IsMatch( content,
                        @"<script|<html|<head|<title|<body|<pre|<table|<a\s+href|<img|<plaintext|<cross\-domain\-policy",
                        RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Multiline ) )
                    {
                        return false;
                    }

                }
                catch (Exception)
                {
                    return false;
                }
            }

            return true;
        }

        #endregion
    }
}