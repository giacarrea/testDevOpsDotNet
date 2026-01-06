FROM mcr.microsoft.com/dotnet/sdk:7.0

# Install common tools
RUN apt-get update && apt-get install -y git sudo && rm -rf /var/lib/apt/lists/*

# Create a non-root vscode user
RUN useradd -m vscode && echo "vscode ALL=(ALL) NOPASSWD:ALL" >> /etc/sudoers

USER vscode
WORKDIR /workspace
