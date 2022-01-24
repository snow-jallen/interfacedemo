using interfacedemo.logic;
using Microsoft.AspNetCore.Components;

namespace interfacedemo.Shared;

public partial class GamePiece
{
    [Parameter]
    public IGamePiece Piece{get;set;}
}