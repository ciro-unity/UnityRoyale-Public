# Unity Royale

A card-based tower defence game replicating gameplay similar to Supercell's Clash Royale (in simplified form). It is possible to play a short match against a "non-smart" AI that just deals cards non-stop.

Built to demonstrate Addressable Assets, it also showcases well URP and custom toon shaders (made with Shader Graph, the lighting done in a Custom Function node), Cinemachine usage, and Timeline Signals. Built for mobile from the ground-up.

![](https://gcl.unity.com/sites/default/files/styles/featured/public/2019-04/AAA.png?itok=YdZr-7Em)

## Unity version
The project has been tested to work with **Unity 2020.3 LTS** (any patch). More recent versions might require upgrading work.

## Usage
To try out the project, just open the scene called "Main", and press Play.

You can find the ScriptableObjects used as cards under the folder "GameData". The 2nd level (the Cards) are the ones that have been marked as Addressable assets, and can be changed without rebuilding the whole game.

To learn about Addressable Assets, there's this talk from Bill Ramsour at Unite LA:
- [New Addressable Assets system for speed and performance](https://www.youtube.com/watch?v=U8-yh5nC1Mg)

You can refer to my this talk at GDC for small tips on the usage of Timeline and Signals:
- [Timeline and Signals talk at GDC](https://www.youtube.com/watch?v=SP3LvN-Q4Rw)

Also, to create a custom toon shader like the one used here you can refer to this talk at Unite Copenhagen:
- [Creating a Stylised Toon Shader with Shader Graph](https://youtu.be/DOLE4nrK97g)

Keep in mind though that the shader in this project is simpler than the one used in the talk.

## Owner and credits
Project created by Ciro Continisio. If you have questions, you can get in touch [on Twitter](https://twitter.com/CiroContns). UI art by [Alice Hinton-Jones](https://twitter.com/alicehintonj)

The shader can be freely used for commercial purposes, no need for credit (though it would be nice).
Assets included are part of a Unity asset pack (see license for details).
