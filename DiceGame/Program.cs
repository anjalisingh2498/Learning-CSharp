// See https://aka.ms/new-console-template for more information

namespace DiceGame{
    class Program{
        static void Main(String[] args){
            int playerRandomNumber;
            int enemyRandomNumber;
            int playerPoints = 0;
            int enemyPoints = 0;
            Random random = new Random();

            for(int i=0;i<10;i++){
                Console.WriteLine("Press any key to roll the dice ");
                Console.ReadKey();

                playerRandomNumber = random.Next(1,7);
                Console.WriteLine("Your Rolled " +  playerRandomNumber);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNumber = random.Next(1,7);
                Console.WriteLine("Enemey Rolled " +  enemyRandomNumber);

                if(playerRandomNumber>enemyRandomNumber){
                    playerPoints++;
                    Console.WriteLine("Player wins this round");
                }else if (playerRandomNumber< enemyRandomNumber){
                    enemyPoints++;
                    Console.WriteLine("Enemy wins this round!");
                }else{
                    Console.WriteLine("Draw!");
                }
                Console.WriteLine("The score is now - Player : " + playerPoints +  " " + "Enemy : "+ enemyPoints + ".");
                Console.WriteLine();

                if(playerPoints>enemyPoints){
                    Console.WriteLine("You Win!");
                }else if(playerPoints<enemyPoints){
                    Console.WriteLine("You lose!");
                }else{
                    Console.WriteLine("It is a draw!");
                }
            }
            Console.ReadKey();
        }
    }
}
