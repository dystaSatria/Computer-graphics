# Bezier Curve

Bezier curve is discovered by the French engineer **Pierre Bézier**. These curves can be generated under the control of other points. Approximate tangents by using control points are used to generate curve. The Bezier curve can be represented mathematically as

<img src="https://live.staticflickr.com/65535/52700333292_52164462b2_w.jpg" width="629" height="100" alt="Screenshot (509)">

The Bezier Curve formula below can be used to define smooth curves between points in space using line handlers (line P0 to P1 and line P2 to P3).
```
P(t) = (1-t)^3P0 + 3(1-t)^2tP1 + 3(1-t)t^2P2 + t^3P3
```

