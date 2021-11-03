using UnityEngine;
using UnityEngine.UI;
namespace Pattern.DependencyInjection
{
    public enum EngineType
    {
        none,
        gas,
        nitro,
        jet
    };

    public enum DriverType
    {
        
        none,
        human,
        android,
        cyborg
    };

    public class Client : MonoBehaviour
    {
        public Bike m_Bike;
        public void CreateBike()
        {
            EngineType engineType = (EngineType)GameObject.Find("EngineDropDown").GetComponent<Dropdown>().value;
            IEngine engine;
            switch (engineType)
            {
                case EngineType.jet:
                    engine = new JetEngine();
                    break;
                case EngineType.nitro:
                    engine = new NitroEngine();
                    break;
                case EngineType.gas:
                    engine = new GasEngine();
                    break;
                default:
                    engine = new NoEngine();
                    break;
            }
            m_Bike.SetEngine(engine);

            DriverType driverType = (DriverType)GameObject.Find("DriverDropDown").GetComponent<Dropdown>().value;
            IDriver driver;
            switch (driverType)
            {
                case DriverType.human:
                    driver = new HumanDriver();
                    break;
                case DriverType.android:
                    driver = new AndroidDriver();
                    break;
                case DriverType.cyborg:
                    driver = new CyborgDriver();
                    break;
                default:
                    driver = new NoDriver();
                    break;
            }
            m_Bike.SetDriver(driver);
        }

        public void StartEngine()
        {
            m_Bike.StartEngine();
        }

        void FixedUpdate()
        {
            if (m_Bike.CanDrive())
                m_Bike.Drive();
        }
        void OnGUI()
        {
            GUI.color = Color.black;
            GUI.Label(new Rect(10, 10, 500, 20), "Press A to turn LEFT and D to turn RIGHT");
            GUI.Label(new Rect(10, 30, 500, 20), "Output displayed in the debug console");
            GUI.Label(new Rect(10, 50, 500, 20), "Human Driver takes inputs");
            GUI.Label(new Rect(10, 70, 500, 20), "Android drives on its own");
            GUI.Label(new Rect(10, 90, 500, 40), "Cyborg takes inputs and drives on its own\nwhen none are given");
           // GUI.Label(new Rect(10, 100, 500, 20), "Output displayed in the debug console");
        }
    }
}