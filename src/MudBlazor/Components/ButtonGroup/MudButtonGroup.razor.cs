﻿using Microsoft.AspNetCore.Components;
using MudBlazor.Extensions;
using MudBlazor.Utilities;

namespace MudBlazor
{
    public partial class MudButtonGroup : MudComponentBase
    {
        protected string Classname =>
        new CssBuilder("mud-button-group-root")
          .AddClass($"mud-button-group-{Variant.ToDescriptionString()}")
          .AddClass($"mud-button-group-{Variant.ToDescriptionString()}-{Color.ToDescriptionString()}")
          .AddClass($"mud-button-group-{Variant.ToDescriptionString()}-size-{Size.ToDescriptionString()}")
          .AddClass($"mud-button-group-vertical", VerticalAlign)
          .AddClass($"mud-button-group-horizontal", !VerticalAlign)
          .AddClass($"mud-button-group-disable-elevation", DisableElevation)
          .AddClass(Class)
        .Build();

        [Parameter] public RenderFragment ChildContent { get; set; }

        /// <summary>
        /// If true, the button group will be displayed vertically.
        /// </summary>
        [Parameter] public bool VerticalAlign { get; set; } = false;

        /// <summary>
        /// If true, the button group will be disabled.
        /// </summary>
        [Parameter] public bool Disabled { get; set; } = false;

        /// <summary>
        /// If true, no drop-shadow will be used.
        /// </summary>
        [Parameter] public bool DisableElevation { get; set; } = false;

        /// <summary>
        /// The color of the component. It supports the theme colors.
        /// </summary>
        [Parameter] public Color Color { get; set; } = Color.Default;

        /// <summary>
        /// The Size of the component.
        /// </summary>
        [Parameter] public Size Size { get; set; } = Size.Medium;

        /// <summary>
        /// The variant to use.
        /// </summary>
        [Parameter] public Variant Variant { get; set; } = Variant.Text;
    }
}
