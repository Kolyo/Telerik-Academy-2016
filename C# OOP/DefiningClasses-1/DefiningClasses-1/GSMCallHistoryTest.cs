using System;
namespace GSM
{
    public class GSMCallHistoryTest
    {

        public static void testCallHistory()
        {
            GSM testGSM = new GSM("Vibe Shor z90", "Lenovo", 199.99m, "Joro", new Battery("Chinese", 208.5f, 13.8f, BatteryType.LiPol), new Display("1920x1080", "16M"));

            testGSM.AddCall(new Call(DateTime.Now, "+359898987413", 85));
            testGSM.AddCall(new Call(new DateTime(2016, 03, 17, 15, 43, 27), "+359898257413", 185));
            testGSM.AddCall(new Call(new DateTime(2016, 03, 18, 15, 43, 27), "+3598981234563", 560));
            testGSM.AddCall(new Call(new DateTime(2016, 02, 18, 15, 43, 27), "+359898987413", 85));

            Call longestCall = testGSM.callHistory[0];

            foreach (var call in testGSM.callHistory)
            {
                Console.WriteLine(call);
                if (longestCall.Duration < call.Duration)
                {
                    longestCall = call;
                }
            }
            Console.WriteLine(testGSM.CallsPrice());
            testGSM.RemoveCall(longestCall);
            Console.WriteLine(testGSM.CallsPrice());
            testGSM.PrintCallHistory();
            testGSM.ClearCalls();
            testGSM.PrintCallHistory();
        }
    }
}
