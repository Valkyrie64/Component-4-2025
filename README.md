# Component 4 User Manual
This will descirbe how the component works and how it will be implemented into the main prototype

## Camera
The camera will move when the E key is pressed to be a top down view, and when Q is pressed it will be a side on view. This will change the design of the levels and add a bit more variety. It functions by using both SmoothDamp for the positioning and Slerp for the rotation.

## Player
The player also moves with the camera, but always into both the middle of the screen and on the same elevation so that enemies and movement won't occur on the wrong level of an axis. This also resets the level for the player to adjust to the camera moving.

## Implementation
In the final protoptype, the cameras movement will also adjust the way the player moves and where the enemies spawn. The player will be constrained on the Y-Axis when the camera is in the top-down position, and the Z-Axis when in the side-on position. The enemies will spawn on the same level as the player to make sure the colliders will hit correctly.
