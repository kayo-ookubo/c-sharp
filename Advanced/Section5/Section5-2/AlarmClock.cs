namespace Section502
{
    class AlarmClock : IAlarm, IClock
    {
        public void SetAlarm()
        {
            Console.WriteLine("アラームをセットする");
        }

        public void Alarm()
        {
            Console.WriteLine("アラームを鳴らす");
        }

        public void StopAlarm()
        {
            Console.WriteLine("アラームを止める");
        }

        public void AdjustTime()
        {
            Console.WriteLine("時刻を修正する");
        }

        public void ShowTime()
        {
            Console.WriteLine("時刻を知る");
        }
    }
}