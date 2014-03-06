namespace Endjin.Web.MetaWeblog.Domain.MetaWeblog.Response
{
    using System;

    public class Post
    {
        public string postid { get; set; }

        public DateTime dateCreated { get; set; }
        
        public string title { get; set; }
        
        public string description { get; set; }

        public string link { get; set; }
        
        public string[] categories { get; set; }
        
        public bool publish { get; set; }

    }
}

/*

From an Azure blog to LiveWriter:

postid
dateCreated
title
description
link
publish
 
wp_slug
mt_excerpt
mt_allow_comments
mt_keywords

From the MetaWeblog API definition's example of a Response:

postid
dateCreated
title
description
link
categories

permaLink
userid

Uses RSS 2.0 "All elements of an item are optional, however at least one of title or description must be present".

What are LiveWriter's minimum requirements when using metaWeblog? 
 
*/