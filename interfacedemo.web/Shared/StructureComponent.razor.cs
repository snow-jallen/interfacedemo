using interfacedemo.logic;
using Microsoft.AspNetCore.Components;

namespace interfacedemo.Shared;

public partial class StructureComponent
{
    [Parameter]
    public Structure Piece{get;set;}
}