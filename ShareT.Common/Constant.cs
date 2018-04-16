using System;
using System.Collections.Generic;
using System.Text;

namespace ShareT.Common
{
    public class Constant
    {
        public const string ShowAllDataCookie = "ShowAllData";
#if BETA
        public const string AUTHENTICATION_SCHEME = "SharedCar.Beta";
#else
        public const string AUTHENTICATION_SCHEME = "SharedCar";
#endif

        public const string WEBSITE_AUTHENTICATION_SCHEME = "Web";
        public const string LAST_LOGIN_PATH = "LAST_LOGIN_PATH";
        public const string CompanyName = "鸟窝开源TOC";

        public const string iOS_ApiKey = "972F5D56-296B-4BD7-8CB6-49617A441A99";
        public const string Android_ApiKey = "506DDE1D-4642-4859-9226-E26B098FC02B";
        public const string WeChatApp_ApiKey = "23ACA89E-0169-44A1-8D08-64AD3EC4A551";
        public const string UploadKey = "C1B702BD-C1D9-4103-A110-BF1A68179C17";
        public const int CanRequestAfterSecond = 120;
        public const int CodeValidMinutes = 10;

        public const string DefaultHeadPicture = "/images/head.png";
        public const string WEBSITE_VERIFICATION_CODE = "ValidateCode";
        public const string UPLOAD_TEMP_PATH = "Upload_Temp";
    }
}
