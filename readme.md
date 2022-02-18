# Basic Maui Application

A basic MAUI app that incorporates dependency injection, shell and some nice C# 10 stuff.

- view models wired up using DI in the page
- shell
	- material icons as tab icons (not working)
	- dependency injection with view model dependency injection
- view models can be wired into some of the page lifecycle events

## Planned

-[ ] turn this into a template 
-[ ] create a template for creating a page with a linked view model and lifecycle events
-[ ] apple and google signin as separate library


## Not Working Currently

- Refresh view throws a null exception if included
- material icons on shell tabs don't seem to be working
- emulator keeps crashing after a few deployments and then needs to be restarted
- toolbar items don't display, but strangely they do during hot reload but the command doesn't work	