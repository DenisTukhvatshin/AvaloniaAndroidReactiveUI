# AvaloniaAndroidReactiveUI
 I found error in ReactiveUI, it is not working in android

- This is avalonia.xplat template, ver 0.10.18.1
- I added button and reaction "click", after click I expected to see a change in the text parameter "Greeting" to "It is working OK!", but this does not happen in Android.

# Steps:
- dotnet run --project .\AvaloniaAndroidReactiveUI.Android
- click on the button "Click"
- we expected to change "TextBlock" with text "Welcome to Avalonia!" to "It is working OK!"
