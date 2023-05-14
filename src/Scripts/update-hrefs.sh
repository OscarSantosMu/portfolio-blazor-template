#!/bin/env bash

cd src || exit

REPO_NAME=$(basename $1)

# Check if file exists
if [ -f "Pages/Index.razor" ]; then
    echo "File exists. Updating file..."
    sed -i "s|NavigationManager.NavigateTo(\"/background\", forceLoad: true);|NavigationManager.NavigateTo(\"/$REPO_NAME/background\", forceLoad: true);|g" Pages/Index.razor
else
    echo "File does not exist"
fi

