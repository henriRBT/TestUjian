﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace TestUjian.Models
{
	public class Product
	{
		[Key]
		public string no_pmh { get; set; }
		public string mbrg_kemasan { get; set; }
		public string kd_satuan { get; set; }
		public float jumlah { get; set; }
	}
}
