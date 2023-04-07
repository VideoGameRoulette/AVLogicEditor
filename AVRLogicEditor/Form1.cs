using Newtonsoft.Json;

namespace AVRLogicEditor
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Locations.Location>? LocationDict;
        private string currentLocation;
        private int selectedLogicIndex;

        public Form1()
        {
            InitializeComponent();
            LocationDict = new Dictionary<string, Locations.Location>();
        }

        private void PopulateLocationList(Dictionary<string, Locations.Location> locationDict)
        {
            if (locationDict == null)
                return;

            List<string> locationNames = new List<string>();

            foreach (var location in locationDict.Values)
                locationNames.Add(location.name);

            LocationList.DataSource = locationNames;
        }

        private void LoadFile_Click(object sender, EventArgs e)
        {
            string filePath = "";
            // create OpenFileDialog object
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // set initial directory (optional)
            openFileDialog.InitialDirectory = Application.StartupPath;

            // set filters to allow only JSON files (optional)
            openFileDialog.Filter = "JSON files (*.json)|*.json";

            // display the file dialog and wait for user's selection
            DialogResult result = openFileDialog.ShowDialog();

            // if user clicks OK, get the file path and store it to filePath variable
            if (result == DialogResult.OK)
                filePath = openFileDialog.FileName;

            LocationDict = Locations.ParseLocations(filePath);

            if (LocationDict != null)
                PopulateLocationList(LocationDict);
        }

        private void LocationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LocationList.SelectedItem == null)
            {
                return;
            }

            currentLocation = LocationList.SelectedItem.ToString();

            if (LocationDict.TryGetValue(currentLocation, out Locations.Location selectedLocation))
            {
                ItemName.Text = selectedLocation.name;
                LocationID.Value = selectedLocation.id;
                RequiredPowersList.DataSource = selectedLocation.requiredPowers.ToList();
                // MessageBox.Show($"Location: {selectedLocation.name}");
            }
        }

        private void RequiredPowersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RequiredPowersList.SelectedItem == null)
            {
                return;
            }
            selectedLogicIndex = RequiredPowersList.SelectedIndex;
            string selectedLogic = RequiredPowersList.SelectedItem.ToString();
            string[] logicList = selectedLogic.Split(new string[] { ", " }, StringSplitOptions.None);
            checkedListBox1.BeginUpdate();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
            foreach (string power in logicList)
            {
                int idx = checkedListBox1.FindStringExact(power);
                checkedListBox1.SetItemChecked(idx, true);
            }
            checkedListBox1.EndUpdate();
        }

        private Locations.Location? GetLocation(string name)
        {
            if (LocationDict.TryGetValue(name, out Locations.Location location))
                return location;
            return null;
        }

        private void updateLogic_Click(object sender, EventArgs e)
        {
            Powers p = Powers.None;
            foreach (var item in checkedListBox1.CheckedItems)
            {
                Powers newPower = (Powers)Enum.Parse(typeof(Powers), item.ToString());
                p |= newPower;
            }
            var l = GetLocation(currentLocation);
            if (l == null) return;
            l.requiredPowers[selectedLogicIndex] = p;
            RequiredPowersList.DataSource = l.requiredPowers.ToList();
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            // Convert dictionary values to array of Location objects
            var locationArray = LocationDict?.Values.ToArray();

            // Serialize Location array to JSON
            string json = JsonConvert.SerializeObject(locationArray, Formatting.Indented);

            // Write JSON to file
            File.WriteAllText("custom.json", json);
        }

        private void AddPowers_Click(object sender, EventArgs e)
        {
            Locations.Location? l = GetLocation(currentLocation);
            if (l == null) return;
            var cPowers = l.requiredPowers;
            Array.Resize(ref cPowers, cPowers.Length + 1);
            cPowers[cPowers.Length - 1] = Powers.None;
            l.requiredPowers = cPowers;
            RequiredPowersList.DataSource = l.requiredPowers.ToList();
        }

        private void RemovePowers_Click(object sender, EventArgs e)
        {
            Locations.Location? l = GetLocation(currentLocation);
            if (l == null) return;
            l.requiredPowers = l.requiredPowers
                .Where((power, index) => index != selectedLogicIndex)
                .ToArray();
            RequiredPowersList.DataSource = l.requiredPowers.ToList();
        }
    }

    public class Locations
    {
        public class Location
        {
            public string name { get; set; }
            public Powers[] requiredPowers { get; set; }
            public int id { get; set; }
        }

        public static Dictionary<string, Location>? ParseLocations(string filename)
        {
            if (filename == null || filename == "") return null;
            List<Location>? locations = JsonConvert.DeserializeObject<List<Location>>(File.ReadAllText(filename));
            if (locations == null) return null;
            return locations.ToDictionary(location => location.name, location => location);
        }
    }

    [Flags]
    public enum Powers
    {
        None = 0,
        Gun = 1 << 0,
        Nova = 1 << 1,
        Drill = 1 << 2,
        Kilver = 1 << 3,
        AddressDisruptor1 = 1 << 4,
        HighJump = 1 << 5,
        Labcoat = 1 << 6,
        Drone = 1 << 7,
        AddressDisruptor2 = 1 << 8,
        Grapple = 1 << 9,
        Trenchcoat = 1 << 10,
        AddressBombs = 1 << 11,
        DroneTeleport = 1 << 12,
        ExtendedDroneLaunch = 1 << 13,
        SudranKey = 1 << 14,
        RedCoat = 1 << 15,
        Password = 1 << 16,
        LongKilver = 1 << 17,
        FatBeam = 1 << 18,
        TeleReset = 1 << 19
    }
}
