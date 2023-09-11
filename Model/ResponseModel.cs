namespace HNGxTest.Model
{
    public class ResponseModel
    {
        public string Slack_name { get; set; }
        public string Current_day { get; set; } = DateTime.Today.DayOfWeek.ToString();
       
        public string Track { get; set; }
        public string Github_file_url { get; set; } = "https://github.com/AyomideAdeyemi/HNGxTest/blob/master/Controllers/HNGxTestController.cs";
        public string Github_repo_url { get; set; } = "https://github.com/AyomideAdeyemi/HNGxTest";
        public DateTime Utc_time { get; set; } = DateTime.UtcNow;
        public int Status_code { get; set; } = 200;
        public ResponseModel()
        {
            Utc_time = Utc_time.AddTicks(-(Utc_time.Ticks % TimeSpan.TicksPerSecond));
        }
    }
}
