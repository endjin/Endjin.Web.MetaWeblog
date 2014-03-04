using System;
using Endjin.Web.MetaWeblog.Domain.MetaWeblog.Response;

namespace Endjin.Web.MetaWeblog.Domain.MetaWeblog.Request
{
    public class NewPostRequest
    {
        public string BlogId { get; set; }
        
        //Not sure if AppKey is necessary here
        public string AppKey { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        //Shouldn't do this as Post is a response object, not a request object. 
        //public Post Post { get; set; } 

        public string title { get; set; }
        
        public string description { get; set; }

        public string link { get; set; }
        
        public string[] categories { get; set; }

        public string Publish { get; set; }

    }
}

