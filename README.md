# Unity Toykit

Lightweight MVC tools for games in Unity 3D C#.

## Features

Convenient amd portable:

* Set animation.
* Set text.
* Play sound.
* Listen to keys and buttons.

Because the models and controllers are separated from the view, the models and controllers are easy to test.
http://www.gamasutra.com/view/news/164363/Indepth\_Unit\_testing\_in\_Unity.php

## Installing

As submodule:

git submodule add git@github.com:ethankennerly/UnityToykit.git Assets/Scripts/UnityToykit

or:

git submodule add https://github.com/ethankennerly/UnityToykit.git Assets/Scripts/UnityToykit

Unity 5.2 or lower
==================

Unity 5.3 builds in NUnit.

http://forum.unity3d.com/threads/editor-test-runner-nunit.358248/

On Unity 5.2 or lower, you can install UnityTestTools from the Asset Store.  I had these included in an earlier commit.  You could download those which are smaller:

https://github.com/ethankennerly/UnityToykit/tree/f2a01b622e39bf52bab54036d710d67f565c7128/UnityTestTools


## Example Game Jam

Toolkit:

https://github.com/ethankennerly/flash-unity-port-example

Older version with a framework:

Add It Up

https://github.com/ethankennerly/add-it-up

Made in one day.

For example of setting text, see:

Assets/Scripts/Main.cs
Assets/Scripts/Model.cs
