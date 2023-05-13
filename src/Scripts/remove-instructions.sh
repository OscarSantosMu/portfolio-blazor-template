#!/bin/env bash

cd src || exit

# Check if file exists
if [ -f "Pages/Index.razor" ]; then
    echo "File exists. Updating file..."
    sed -i 's/await JSRuntime.InvokeAsync<string>("localStorage.getItem", "allChecked");/"true";/g' Pages/Index.razor
    sed -i 's/NavigationManager.NavigateTo("/background", forceLoad: true);/NavigationManager.NavigateTo("/portfolio-blazor-template/background", forceLoad: true);/g' Pages/Index.razor
else
    echo "File does not exist"
fi

# Check if file exists
if [ -f "Shared/NavMenu.razor" ]; then
    echo "File exists. Updating file..."
    sed -i 's/await JSRuntime.InvokeAsync<string>("localStorage.getItem", "allChecked");/"true";/g' Shared/NavMenu.razor
else
    echo "File does not exist"
fi

# Check if file exists
if [ -f "Pages/ProjectCard.razor" ]; then
    echo "File exists. Updating file..."
    sed -i 's/<a href="/project/@data?.Title" class="projectUrl">/<a href="/portfolio-blazor-template/project/@data?.Title" class="projectUrl">/g' Pages/ProjectCard.razor
else
    echo "File does not exist"
fi