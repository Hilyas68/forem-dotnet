﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Forem.Api.Models;

namespace Forem.Api
{
	public class PodcastEpisodesService : ApiService, IPodcastEpisodesService
	{
		public PodcastEpisodesService(Uri baseUri, HttpClient httpClient) : base(baseUri, httpClient) { }

		public Task<IEnumerable<PodcastEpisode>> GetPodcastEpisodesAsync(string username = "", int page = 1, int perPage = 30)
		{
			var parameters = new Dictionary<string, object>
				{
					{ "page", page },
					{ "per_page", perPage },
				};

			if (!string.IsNullOrEmpty(username))
			{
				parameters.Add("username", username);
			}

			return GetAsync<IEnumerable<PodcastEpisode>>("/api/podcast_episodes", parameters);
		}
	}
}
