#!/bin/env bash

cd src || exit

REPO_NAME=portfolio-blazor-template
REPO_NAME2=$(basename ${{ github.repository }})
echo $REPO_NAME2

# Check if file exists
if [ -f "Pages/Index.razor" ]; then
    echo "File exists. Updating file..."
    sed -i "s|NavigationManager.NavigateTo(\"/background\", forceLoad: true);|NavigationManager.NavigateTo(\"/$REPO_NAME/background\", forceLoad: true);|g" Pages/Index.razor
else
    echo "File does not exist"
fi

# Check if file exists
if [ -f "Pages/ProjectCard.razor" ]; then
    echo "File exists. Updating file..."
    sed -i "s|<a href=\"/project/@data?.Title\" class=\"projectUrl\">|<a href=\"/$REPO_NAME/project/@data?.Title\" class=\"projectUrl\">|g" Pages/ProjectCard.razor
else
    echo "File does not exist"
fi