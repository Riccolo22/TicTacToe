t using System;
using static System.Console;

class MainClass {
  public static void Main (string[] args) {
    //TTT();
    TTL();
  }

  public static void TTT (){
    int a = 0;
    while(a == 0){
      WriteLine(@"
                    1 │  2  │ 3
                 ─────┼─────┼─────
                    4 │  5  │ 6            
                 ─────┼─────┼─────
                    7 │  8  │ 9 ");
      Write("Enter the number for the chosen square: ");
      var b = ReadLine();
      if (b == "1"){
        WriteLine(@"
                      X │  2  │ 3
                   ─────┼─────┼─────
                      4 │  5  │ 6            
                   ─────┼─────┼─────
                      7 │  8  │ 9 ");

      }
      else if (b == "2"){
        WriteLine(@"
                      1 │  X  │ 3
                   ─────┼─────┼─────
                      4 │  5  │ 6            
                   ─────┼─────┼─────
                      7 │  8  │ 9 ");        
      }
      else if (b == "3"){
        WriteLine(@"
                      1 │  2  │ X
                   ─────┼─────┼─────
                      4 │  5  │ 6            
                   ─────┼─────┼─────
                      7 │  8  │ 9 ");   
      } 
      else if (b == "4"){
        WriteLine(@"
                      1 │  2  │ 3
                   ─────┼─────┼─────
                      X │  5  │ 6            
                   ─────┼─────┼─────
                      7 │  8  │ 9 ");   
      } 
      else if (b == "5"){
        WriteLine(@"
                      1 │  2  │ 3
                   ─────┼─────┼─────
                      4 │  X  │ 6            
                   ─────┼─────┼─────
                      7 │  8  │ 9 ");  
                     
      } 
      else if (b == "6"){
        WriteLine(@"
                      1 │  2  │ 3
                   ─────┼─────┼─────
                      4 │  5  │ X            
                   ─────┼─────┼─────
                      7 │  8  │ 9 ");   
      } 
      else if (b == "7"){
        WriteLine(@"
                      1 │  2  │ 3
                   ─────┼─────┼─────
                      4 │  5  │ 6            
                   ─────┼─────┼─────
                      X │  8  │ 9 ");   
      } 
      else if (b == "8"){
        WriteLine(@"
                      1 │  2  │ 3
                   ─────┼─────┼─────
                      4 │  5  │ 6            
                   ─────┼─────┼─────
                      7 │  X  │ 9 ");   
      } 
      else if (b == "9"){
        WriteLine(@"
                      1 │  2  │ 3
                   ─────┼─────┼─────
                      4 │  5  │ 6            
                   ─────┼─────┼─────
                      7 │  8  │ X ");   
      } 
      else{
        WriteLine("Invalid entry");
      }
    }
  }

  public static void TTL (){
    var win = false;
    var input = true;
    string[,] board = new string [,] {
    {"1","  │  " ,"2"," │  " ,"3"},
    {"───","┼","────","┼","─────"},
    {"4","  │  ", "5"," │  ", "6"},
    {"───","┼","────","┼","─────"},
    {"7","  │  ", "8"," │  ", "9"}
    };
    while (win == false){
      int rowLength = board.GetLength(0);
          int colLength = board.GetLength(1);

          for (int i = 0; i < rowLength; i++)
          {
              for (int j = 0; j < colLength; j++)
              {
                  Console.Write("{0} ", board[i, j]);
              }
              Write(Environment.NewLine);
          }
      int moves = 0;
      int aimove = 0;
      WriteLine("\n");
      Write("Enter the collum: ");
      var co = ReadLine();
      int col;
      col = Convert.ToInt32(co);
      if (col == 1){
        col -= 1;
        
      }
      else if (col == 3){
        col += 1;    
      }
      else if (col > 3){
        WriteLine("\n");
        WriteLine("Invalid Input.");
      }
      Write("Enter the row: ");
      var ro = ReadLine();
      int row;
      row = Convert.ToInt32(ro);
      
      if (row == 1){
        row -= 1;
      }
      else if (row == 3){
        row += 1;
      }
      else if (row > 3){
        WriteLine("\n");
        WriteLine("Invalid Input.");
      }

      if (board[row,col] == "O"){
        WriteLine("Invalid Choice");
      }
      else if (board[row,col] == "X"){
        WriteLine("Invalid Choice");
      }
      else {
        board[row, col] = "X";
        moves += 1;
      }

      Random rand = new Random();
      int move = rand.Next(0,4);
      if (move == 1){
        move -=1;
      }
      else if (move == 3){
        move += 1;
      }
      int move2 = rand.Next(0,4);
      if (move2 == 1){
        move2 -=1;
      }
      else if (move2 == 3){
        move2 += 1;
      }


      if (board[move,move2] != "X" && board[move,move2] != "O"){
        board[move,move2] = "O";

      }
      else{
        int movea = rand.Next(0,4);
        if (movea == 1){
          movea -=1;
        }
        else if (movea == 3){
          movea += 1;
        }
        int move2a = rand.Next(0,4);
        if (move2a == 1){
          move2a -=1;
        }
        else if (move2a == 3){
          move2a += 1;
        }
        if (board[movea,move2a] != "X" && board[movea,move2a] != "O"){
        board[movea,move2a] = "O";
        }
        else{
          int moveb = rand.Next(0,4);
          if (moveb == 1){
            moveb -=1;
          }
          else if (moveb == 3){
            moveb += 1;
          }
          int move2b = rand.Next(0,4);
          if (move2b == 1){
            move2b -=1;
          }
          else if (move2b == 3){
            move2b += 1;
          }
          if (board[moveb,move2b] != "X" && board[moveb,move2b] != "O"){
          board[moveb,move2b] = "O";
          }

      }

    }
    }
  }

  public static bool check (){
    int countX = 0;
    int countO = 0;
    for (int i < 5 ; i++){
      int a = 0;
      if
    }
  }
}