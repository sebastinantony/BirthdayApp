﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirthdayApp.App_Code
{
    public class Facebook
    {
        public string ClientId;
        public string SignInUrl;
        public string FinalSignInUrl;
        public string RedirectUri;

        public Facebook(string clientId, string signInUrl, string redirectUri)
        {
            this.ClientId = clientId;
            this.SignInUrl = signInUrl;
            this.RedirectUri = redirectUri;
            this.FinalSignInUrl = this.SignInUrl + "?client_id=" + this.ClientId + "&redirect_uri=" 
                + HttpUtility.UrlEncode(HttpContext.Current.Request.Url.Scheme + "://" + HttpContext.Current.Request.Url.Authority + this.RedirectUri)
                + "&scope=friends_birthday,friends_relationships";
        }
    }
}