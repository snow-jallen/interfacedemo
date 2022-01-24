using interfacedemo.logic;
using Microsoft.AspNetCore.Components;

namespace interfacedemo.Shared;

public partial class PlayerComponent
{
    [Parameter]
    public Player Piece{get;set;}
}