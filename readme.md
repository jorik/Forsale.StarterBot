# Forsale Starterbot

## Getting started
  1. Register your bot on http://botchallenge.intern.infi.nl/
  2. Copy the API key and paste it in `Program.cs` and `Makefile`
  
## Running your bot

Your default-bot is able to join matches in the cloud and locally. When you run your bot in your IDE / from the commandline it will automatically join a remote match.

## Deploying your bot

The bot has to be uploaded for it to be able to participate in tournaments or matches against other bots. 

Deploying is as easy as running `make publish` from the commandline. Make sure you have put your API-key in the Makefile.

## bot.conf

This file is used when running your bot in the cloud. The worker will start a `dotnet` process using the `entrypoint` as its argument.
The entrypoint-file is expected to be in the root of the project.  
