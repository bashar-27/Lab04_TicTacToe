using Lab04_TicTacToe.Classes;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test()
        {
            // Arrange
            Player playerOne = new Player();
            playerOne.Name = "Player1";
            playerOne.Marker = "X";
            playerOne.IsTurn = true;

            Player playerTwo = new Player();
            playerTwo.Name = "Player2";
            playerTwo.Marker = "O";
            Game game = new Game(playerOne, playerTwo);
            game.Board.GameBoard[0, 0] = "X";
            game.Board.GameBoard[0, 1] = "X";
            game.Board.GameBoard[0, 2] = "X";
            // Act
            bool hasWinner = game.CheckForWinner(game.Board);
            // Assert
            Assert.Equal(hasWinner, true);

        }
        [Fact]
        public void Test2()
        {
            // Arrange
            Player playerOne = new Player();
            playerOne.Name = "Player1";
            playerOne.Marker = "X";
            playerOne.IsTurn = true;
            Player playerTwo = new Player();
            playerTwo.Name = "Player2";
            playerTwo.Marker = "O";
            Game game = new Game(playerOne, playerTwo);
            game.Board.GameBoard[1, 0] = "X";
            game.Board.GameBoard[1, 1] = "O";
            game.Board.GameBoard[1, 2] = "x";
            // Act
            bool hasWinner = game.CheckForWinner(game.Board);
            // Assert
            Assert.Equal(hasWinner, false);

        }
        [Fact]
        public void Test3()
        {
            // Arrange
            Player playerOne = new Player();
            playerOne.Name = "Player1";
            playerOne.Marker = "X";
            playerOne.IsTurn = true;
            Player playerTwo = new Player();
            playerTwo.Name = "Player2";
            playerTwo.Marker = "O";
            Game game = new Game(playerOne, playerTwo);

            game.SwitchPlayer();
            // Act
            bool change =playerOne.IsTurn==false && playerTwo.IsTurn==true;
           ;
            // Assert
            Assert.Equal(change,true);

        }
        [Fact]
        public void Test4()
        {
            // Arrange
            Player playerOne = new Player();
            playerOne.Name = "Player1";
            playerOne.Marker = "X";
            playerOne.IsTurn = true;
            Player playerTwo = new Player();
            playerTwo.Name = "Player2";
            playerTwo.Marker = "O";
            Game game = new Game(playerOne, playerTwo);
           Position pos= Player.PositionForNumber(1);

         
            // Assert
            Assert.Equal(game.Board.GameBoard[pos.Row,pos.Column], "1");
            //Assert.Equal(pos.Column, indexcol);
        }
        [Fact]
        public void Test5()
        {
            // Arrange
            Player playerOne = new Player();
            playerOne.Name = "Player1";
            playerOne.Marker = "X";
            playerOne.IsTurn = true;
            Player playerTwo = new Player();
            playerTwo.Name = "Player2";
            playerTwo.Marker = "O";
            Game game = new Game(playerOne, playerTwo);
            Player player = game.NextPlayer();

            // Assert
            Assert.Equal(player,playerOne);
            //Assert.Equal(pos.Column, indexcol);
        }

    }

}