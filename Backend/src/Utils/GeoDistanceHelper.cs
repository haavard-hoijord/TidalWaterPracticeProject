﻿namespace Backend.Utils;

public static class GeoDistanceCalculator
{
	public static double Haversine(double lat1, double lon1, double lat2, double lon2)
	{
		const double r = 6371; // Earth's radius in kilometers
		var dLat = ToRadians(lat2 - lat1);
		var dLon = ToRadians(lon2 - lon1);

		var a =
			Math.Sin(dLat / 2) * Math.Sin(dLat / 2) + Math.Cos(ToRadians(lat1)) * Math.Cos(ToRadians(lat2)) * Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

		var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

		return r * c;
	}

	private static double ToRadians(double degrees)
	{
		return degrees * (Math.PI / 180);
	}
}
