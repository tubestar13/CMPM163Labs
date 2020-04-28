# CMPM163Labs
Lab folder for all CMPM163 assignments

## Lab 2
Video Link: https://drive.google.com/file/d/1-dZi7MJLJZeo0DjhtaYiLRFxRfk4IQVu/view?usp=sharing
![](lab2/lab2part2.png)

## Lab 3
Video Link: https://drive.google.com/open?id=1GQF1pTJrJmd04uPCXmT4W7J6Vj1LPf_v

For the first cube on the left I created a sky blue cube with lambert material and changed the emission to a red color.

For the second cube is a phong material cube with a green shine

For the third cube, it is an interpolation of spring bud and sky blue using the uVu's z coordinate 

For the fourth cube it is an interpolation of interpolating Olive and Dark Cyan using the uVu's z coordinate and interpolating Citrus and Iris Blue using the uVu's y coordinate using the uVu's x coordinate.

## Lab 4
Answers to 24:
a) 8 * u
b) 8 - (8 * v)
c) (3,6) white
Video Link: https://drive.google.com/open?id=1xsqtdokK5F1LJxs5c40K1sAZj9nfT7Sy

The left-most cube is just a cube using the texture 197 without the normal texture

The center-most cube is the same texture as the left-most cube except it has the normal texture

The cube above the center-most cube is texture 191 with the normal texture

The right-most cube is texture 165 using a separate vertex shader and fragment shader

The cube above the right-most cube is a texture 176 tiled into a 2x2 grid. I managed this by scaling the tile down by multiplying it by a vec2(2), then essentially grabbing the portion of the texture that I wanted and pasting them to the other three spaces of the cube by moving texture by either a vec2(1), vec2(1,0), or vec2(0,1) since the texture was scaled by a vec2(2).