﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListRM23Tindakan
    {
        public int Kode { get; set; }

        public string Tindakan { get; set; }

        public int Deleted { get; set; }



        //FK
        public int KodeRM23 { get; set; }

        public int KodeICD9 { get; set; }
        public string UraianICD9 { get; set; }

    }
}
