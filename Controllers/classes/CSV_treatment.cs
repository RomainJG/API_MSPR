using MSPR_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSPR_API.Controllers.classes
{
    public class CSV_treatment
    {
        public static List<Information> Convert(string _csv)
        {
            string[] csv = _csv.Split(new string[] { ";" }, StringSplitOptions.None);
            List<Information> infos = new List<Information>();

            for (int i =0; i< csv.Length; i += 3)
            {
                infos.Add(new Information(int.Parse(csv[i]),csv[i+1],csv[i+2]));
            }

            return infos;
        }
    }
}