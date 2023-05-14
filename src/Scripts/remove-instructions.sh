#!/bin/env bash

cd src || exit

# Check if file exists
if [ -f "Pages/Index.razor" ]; then
    echo "File exists. Updating file..."
    sed -i 's/await JSRuntime.InvokeAsync<string>("localStorage.getItem", "allChecked");/"true";/g' Pages/Index.razor
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