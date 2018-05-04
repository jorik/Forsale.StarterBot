.PHONY: publish upload

# Also put the API key in Program.cs
APIKEY := your-api-key

all: help

help:
	@echo "ForSale Starterbot"
	@echo ""
	@echo "make build - build the bot"
	@echo "make upload - upload the bot that has been build"
	@echo "make publish - build & upload"
	@echo "make run - run the bot against testopponents in the cloud"

publish: build upload
	
upload:
	@echo Publishing your bot...
	curl -X POST -Ffile=@./publish/build.zip http://botchallenge.intern.infi.nl/api/upload/bot/$(APIKEY)
    
build:
	dotnet publish -c Release -o ./publish
	cd ./publish && zip -r build.zip *

run:
	dotnet run
