using Microsoft.AspNetCore.Components;
using PizzaPlace_2022_.Shared;
using System.Collections.Generic;

namespace PizzaPlace_2022_.Client.Pages
{
    partial class PizzaList
    {
        [Parameter]
        public string Title { get; set; } = default!;
        [Parameter]
        public IEnumerable<Pizza> Items { get; set; } = default!;
        [Parameter]
        public string ButtonClass { get; set; }= default!;
        [Parameter]
        public string ButtonTitle { get; set; } = default!;
        [Parameter]
        public EventCallback<Pizza> Selected { get; set; }
    }
}
