using Lab2Lib;
using System.Text;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Camera[] arrCameras;
            Console.Write("Введіть кількість камер: ");
            int cntCameras = int.Parse(Console.ReadLine());
            arrCameras= new Camera[cntCameras];
            for (int i = 0; i < cntCameras; i++)
            {
                Console.Write("Введіть назву бренду фотоапарата: ");
                string cBrand = Console.ReadLine();
                Console.Write("Введіть назву моделі фотоапарата: ");
                string cModel = Console.ReadLine();
                Console.Write("Введіть назву країни виробника фотоапарата: ");
                string cCountry = Console.ReadLine();
                Console.Write("Введіть тип сенсора фотоапарата: ");
                string cSensorType = Console.ReadLine();
                Console.Write("Введіть роздільну здатність серсора фотоапарата: ");
                string cSensorResolution = Console.ReadLine();
                Console.Write("Введіть тип об'єктиву фотоапарата: ");
                string cLensType = Console.ReadLine();
                Console.Write("Введіть формат відео фотоапарата: ");
                string cVideoFormat = Console.ReadLine();
                Console.Write("Чи захищений фотоапарат від пилу та вологи (y-так, n-ні): ");
                ConsoleKeyInfo cWeatherSealing = Console.ReadKey();
                Console.WriteLine(); Console.WriteLine();
                Camera camera = new Camera();
                camera.Brand = cBrand;
                camera.Model = cModel;
                camera.CountryOfOrigin = cCountry;
                camera.SensorResolution = int.Parse(cSensorResolution);
                camera.LensType = cLensType;
                camera.SensorType = cSensorType;
                camera.VideoFormat = cVideoFormat;
                camera.WeatherSealing = cWeatherSealing.Key == ConsoleKey.Y ? true : false;
                arrCameras[i] = camera;
            }
            foreach (var camera in arrCameras)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Дані про камеру {0}:", camera.FullName);
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Бренд: " + camera.Brand);
                Console.WriteLine("Модель: " + camera.Model);
                Console.WriteLine("Країна виробник: " + camera.CountryOfOrigin);
                Console.WriteLine("Роздільна здатність сенсора: " + camera.SensorResolution + " мегапікселів");
                Console.WriteLine("Тип об'єктиву: " + camera.LensType);
                Console.WriteLine("Тип сенсора: " + camera.SensorType);
                Console.WriteLine("Формат відео: " + camera.VideoFormat);
                Console.WriteLine(camera.WeatherSealing ? "Фотоапарат має захист від пилу та вологи" : 
                    "Фотоапарат не має захисту від пилу та вологи");
                Console.WriteLine("Повна назва фотоапарату: " + camera.FullName);
            }
            Console.ReadKey();
        }
    }
}