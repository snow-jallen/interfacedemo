using System.Text;
using interfacedemo.logic;
using Microsoft.AspNetCore.Components;

namespace interfacedemo.Shared;

public partial class Board
{
    [Parameter]
    public IEnumerable<IGamePiece> Pieces{get;set;}

    [Parameter]
    public int Rows{get;set;} = 5;
    [Parameter]
    public int Columns{get;set;} = 5;

    public string gridTemplateRows => String.Join(" ", Enumerable.Repeat("1fr", Rows));
    public string gridTemplateColumns => String.Join(" ", Enumerable.Repeat("1fr", Columns));

    public string gridTemplateAreas()
    {
        var sb = new StringBuilder();
        for(int row=0;row<Rows;row++)
        {
            sb.Append("\"");
            for(int col=0;col<Columns;col++)
            {
                sb.Append($"r{row}c{col} ");
            }
            sb.AppendLine("\"");
        }
        return sb.ToString();
    }

    public string cellClasses()
    {
        var sb = new StringBuilder();
        for(int row=0;row<Rows;row++)
        {
            for(int col=0;col<Columns;col++)
            {
                sb.AppendLine($".r{row}c{col} {{grid-area: r{row}c{col};}} ");
            }
        }
        return sb.ToString();
    }
}