using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Hermeco.UtilidadesChaoSAP.Infogeografica
{
    public static class Utilities
    {
        public static string RemoveSpecialCharacters(this string str)
        {
            return Regex.Replace(str, @"[^\w\d\s]", "");
        }
    }
}