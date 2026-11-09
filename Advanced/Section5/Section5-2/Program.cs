namespace Section502
{
    class Program
    {
        static void Main(string[] args)
        {
            AlarmClock alarmClock = new AlarmClock();

            alarmClock.SetAlarm();
            alarmClock.Alarm();
            alarmClock.StopAlarm();

            alarmClock.AdjustTime();
            alarmClock.ShowTime();
        }
    }
}