using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.ConsoleColor;
namespace _79_Escape_from_Labyrinth
{
	class Program
	{
		private const string InputFileName = @"..\..\Problem2.in";
		private const string OutputFileName = @"..\..\Problem2.out";
		class Maze
		{

			

			class Cell
			{
				public int Row { get; set; }
				public int Column { get; set; }
				public int Distance { get; set; }
				public Cell(int row, int column, int distance)
				{
					this.Row = row;
					this.Column = column;
					this.Distance = distance;
				}

			}
			private char[,] maze; //create maze=Labyrinth
			private int size;
			private Cell startCell = null;
			public void ReadFromFile(string fileName)
			{

				using (StreamReader reader = new StreamReader(fileName))
				{

					this.size = int.Parse(reader.ReadLine());
					this.maze = new char[this.size, this.size];
					for (int row = 0; row < this.size; row++)
					{
						string line = reader.ReadLine();
						for (int col = 0; col < this.size; col++)
						{
							this.maze[row, col] = line[col];
							if (line[col] == '*')
							{
								this.startCell = new Cell(row, col, 0);
							}
						}
					}
				}
			}

			public int FindShortestPath()
			{

				if (this.startCell == null)
				{
					// Start cell is missing -> no path
					return -1;
				}
				Queue<Cell> visitedCells = new Queue<Cell>();
				VisitedCell(visitedCells, this.startCell.Row, this.startCell.Column, 0);
				while (visitedCells.Count > 0)
				{
					Cell currentCell = visitedCells.Dequeue();
					int row = currentCell.Row;
					int column = currentCell.Column;
					int distance = currentCell.Distance;
					if ((row == 0) || (row == size - 1) || (column == 0) || (column == size - 1))
					{
						return distance + 1;
					}
					VisitedCell(visitedCells, row, column + 1, distance + 1);
					VisitedCell(visitedCells, row, column - 1, distance + 1);
					VisitedCell(visitedCells, row + 1, column, distance + 1);
					VisitedCell(visitedCells, row - 1, column, distance + 1);
				}
				return -1;
			}
			private void VisitedCell(Queue<Cell> visitedCells, int row, int column, int distance)
			{

				if (this.maze[row, column] != 'x')
				{
					// The cell is free --> visit it
					maze[row, column] = 'x';
					Cell cell = new Cell(row, column, distance);
					visitedCells.Enqueue(cell);
				}
			}

			public void SaveResult(string fileName, int result)
			{

				using (StreamWriter writer = new StreamWriter(fileName))
				{
					writer.WriteLine(result);
				}
			}
		}
		
		static void Main(string[] args)
		{
			Maze maze = new Maze();
			maze.ReadFromFile(InputFileName);
			int pathLength = maze.FindShortestPath();
			maze.SaveResult(OutputFileName, pathLength);
			WriteLine("Maze path length : {0}", pathLength);
			
			ReadKey();
		}
	}
}
