﻿using AirlinesManagerGame.Airplanes;

namespace AirlinesManagerGame.Airports.Cities
{
    public sealed class PhoenixAirport : Airport
    {
        private static readonly PhoenixAirport phxAirport = new PhoenixAirport();

        private PhoenixAirport()
        {
            Name = "Phoenix Airport";
        }

        public static PhoenixAirport Instance { get { return phxAirport; } }

        public override void LandPlane(Airplane airplane)
        {
            DockedAirplanes.Add(airplane);
            airplane.Location = phxAirport;
        }
    }
}
