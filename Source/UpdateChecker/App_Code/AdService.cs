﻿#region Using directives.
// --------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Globalization;
using System.Web.Services;

// --------------------------------------------------------------------------
#endregion

/// <summary>
/// 
/// </summary>
[Serializable]
public struct AdRequest
{
	#region Public variables.
	// ----------------------------------------------------------------------

	public int Culture;

	// ----------------------------------------------------------------------
	#endregion
}

/// <summary>
/// 
/// </summary>
[Serializable]
public struct AdResponse
{
	/// <summary>
	/// 
	/// </summary>
	public AdResponse(
		string text,
		string url )
	{
		Text = text;
		Url = url;
	}

	#region Public variables.
	// ----------------------------------------------------------------------

	public string Text;
	public string Url;

	// ----------------------------------------------------------------------
	#endregion
}

/// <summary>
/// Serves ads for the Windows client.
/// </summary>
[WebService( Namespace = @"http://zeta-resource-editor.com/" )]
[WebServiceBinding( ConformsTo = WsiProfiles.BasicProfile1_1 )]
public class AdService :
	ApiKeyProtectedWebServiceBase
{
	/// <summary>
	/// 
	/// </summary>
	private static readonly AdResponse[] stockResponses =
		new[]
		{
			/*
			new AdResponse(
				@"SR_AdService_stockResponses_ZetaProducer",
				@"http://zeta-software.de/links/zre-link--zeta-producer" ),
			new AdResponse(
			    @"SR_AdService_stockResponses_ZetaUploader",
			    @"http://zeta-software.de/links/zre-link--zeta-uploader" ),*/
			new AdResponse(
				@"SR_AdService_stockResponses_ZetaTest",
				@"http://zeta-software.de/links/zre-link--zeta-test" ),
		};

	private static readonly Random _rnd = new Random();

	#region Web methods.
	// ----------------------------------------------------------------------

	/// <summary>
	/// 
	/// </summary>
	[WebMethod(
		Description = @"Returns an ad to display inside the Zeta Resource Editor. Simple version." )]
	public AdResponse GetNextAdSimple()
	{
		try
		{
			return GetNextAd( new AdRequest() );
		}
		catch ( Exception x )
		{
			Trace.TraceError( x.Message );
			throw;
		}
	}

	/// <summary>
	/// 
	/// </summary>
	[WebMethod(
		Description = @"Returns an ad to display inside the Zeta Resource Editor. Extended version." )]
	public AdResponse GetNextAd(
		AdRequest request )
	{
		try
		{
			// Fetch randomly.
			var resp = stockResponses[_rnd.Next( 0, stockResponses.Length )];

			// Translate the resources.
			var ci = CultureInfo.GetCultureInfo(request.Culture);

			resp.Text = 
				Resources.Resources.ResourceManager.GetString( 
				resp.Text, 
				ci );

			return resp;
		}
		catch ( Exception x )
		{
			Trace.TraceError( x.Message );
			throw;
		}
	}

	// ----------------------------------------------------------------------
	#endregion
}