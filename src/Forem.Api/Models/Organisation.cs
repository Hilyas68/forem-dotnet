﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forem.Api.Models
{
	public class Organisation
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("username")]
		public string Username { get; set; }
		[JsonProperty("slug")]
		public string Slug { get; set; }

		[JsonProperty("profile_image")]
		public Uri ProfileImageLarge { get; set; }
		[JsonProperty("profile_image_90")]
		public Uri ProfileImageSmall { get; set; }
	}
}
