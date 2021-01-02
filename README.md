# Simple ReactiveUI Demo

This simple WPF demo with [ReactiveUI](http://www.reactiveui.net/) 

I have added a file search which searches for files in the local My Pictures folder of the user. If you want to replace the Flickr photo search from the original example with the local file search just replace the following line in AppViewModel.cs:

```csharp
var ExecuteSearch = ReactiveCommand.CreateFromTask((string searchedTerm) => FlickrPhotoSearch.Search(searchedTerm));
```

with

```csharp
var ExecuteSearch = ReactiveCommand.CreateFromTask((string searchedTerm) => MyPicturesSearch.Search(searchedTerm));
```