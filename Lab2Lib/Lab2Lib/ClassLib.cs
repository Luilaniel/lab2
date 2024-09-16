namespace Lab2Lib
{
    public class Camera
    {
        public string Brand;
        public string Model;
        public string CountryOfOrigin;
        public string SensorType;
        public int SensorResolution;
        public string LensType;
        public string VideoFormat;
        public bool WeatherSealing;
        public string GetFullName()
        {
            return Brand + " " + Model;
        }
        public string FullName
        {
            get
            {
                return GetFullName();
            }

        }
    }
}