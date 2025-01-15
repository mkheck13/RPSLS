namespace RPSLS.Services
{
    public class RPSLSServices
    {
        public string RPSLS()
        {
            string[] cpuOutput =
            [
                "Rock",
                "Paper",
                "Scissors",
                "Lizard",
                "Spock"
            ];

            int randomIndex = new Random().Next(0, cpuOutput.Length);

            return cpuOutput[randomIndex];
        } 

       
    }
}