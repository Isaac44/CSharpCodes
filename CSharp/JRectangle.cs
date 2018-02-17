using System;
using System.Drawing;

namespace Utils {
	class JRectangle {

        //
        // Summary
        // The X coordinate of the upper-left corner of the <code>JRectangle</code>.
        //
        // @serial
        // @see #setLocation(int, int)
        // @see #getLocation()
        // @since 1.0
        private int X { get; set; }

        //
        // Summary
        // The Y coordinate of the upper-left corner of the <code>JRectangle</code>.
        //
        // @serial
        // @see #setLocation(int, int)
        // @see #getLocation()
        // @since 1.0
        //
        private int Y { get; set; }

        //
        // Summary
        // The Width of the <code>JRectangle</code>.
        // @serial
        // @see #setSize(int, int)
        // @see #getSize()
        // @since 1.0
        //
        private int Width { get; set; }

        //
        // Summary
        // The Height of the <code>JRectangle</code>.
        //
        // @serial
        // @see #setSize(int, int)
        // @see #getSize()
        // @since 1.0
        //
        private int Height { get; set; }

        //
        // Summary
        // Constructs a new <code>JRectangle</code> whose upper-left corner
        // is at (0,&nbsp;0) in the coordinate space, and whose Width and
        // Height are both zero.
        //
        public JRectangle() : this(0, 0, 0, 0) {
        }

        //
        // Summary
        // Constructs a new <code>JRectangle</code>, initialized to match
        // the values of the specified <code>JRectangle</code>.
        // @param r  the <code>JRectangle</code> from which to copy initial values
        //           to a newly constructed <code>JRectangle</code>
        // @since 1.1
        //
        public JRectangle(JRectangle r) : this(r.X, r.Y, r.Width, r.Height) {
        }

        //
        // Summary
        // Constructs a new <code>JRectangle</code> whose upper-left corner is
        // specified as
        // {@code (X,Y)} and whose Width and Height
        // are specified by the arguments of the same name.
        // @param     X the specified X coordinate
        // @param     Y the specified Y coordinate
        // @param     Width    the Width of the <code>JRectangle</code>
        // @param     Height   the Height of the <code>JRectangle</code>
        // @since 1.0
        //
        public JRectangle(int x, int y, int width, int height) {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }

        //
        // Summary
        // Constructs a new <code>JRectangle</code> whose upper-left corner
        // is at (0,&nbsp;0) in the coordinate space, and whose Width and
        // Height are specified by the arguments of the same name.
        // @param Width the Width of the <code>JRectangle</code>
        // @param Height the Height of the <code>JRectangle</code>
        //
        public JRectangle(int Width, int Height) : this(0, 0, Width, Height) {
        }

        //
        // Summary
        // Constructs a new <code>JRectangle</code> whose upper-left corner is
        // specified by the {@link Point} argument, and
        // whose Width and Height are specified by the
        // {@link Size} argument.
        // @param p a <code>Point</code> that is the upper-left corner of
        // the <code>JRectangle</code>
        // @param d a <code>Size</code>, representing the
        // Width and Height of the <code>JRectangle</code>
        //
        public JRectangle(Point p, Size d) : this(p.X, p.Y, d.Width, d.Height) {
        }

        //
        // Summary
        // Constructs a new <code>JRectangle</code> whose upper-left corner is the
        // specified <code>Point</code>, and whose Width and Height are both zero.
        // @param p a <code>Point</code> that is the top left corner
        // of the <code>JRectangle</code>
        //
        public JRectangle(Point p) : this(p.X, p.Y, 0, 0) {
        }

        //
        // Summary
        // Constructs a new <code>JRectangle</code> whose top left corner is
        // (0,&nbsp;0) and whose Width and Height are specified
        // by the <code>Size</code> argument.
        // @param d a <code>Size</code>, specifying Width and Height
        //
        public JRectangle(Size d) : this(0, 0, d.Width, d.Height) {
        }

        //
        // Summary
        // Gets the bounding <code>JRectangle</code> of this <code>JRectangle</code>.
        // <p>
        // This method is included for completeness, to parallel the
        // <code>getBounds</code> method of
        // {@link Component}.
        // @return    a new <code>JRectangle</code>, equal to the
        // bounding <code>JRectangle</code> for this <code>JRectangle</code>.
        // @see       java.awt.Component#getBounds
        // @see       #setBounds(JRectangle)
        // @see       #setBounds(int, int, int, int)
        // @since     1.1
        //
        public JRectangle GetBounds() {
            return new JRectangle(X, Y, Width, Height);
        }

        //
        // Summary
        // Sets the bounding <code>JRectangle</code> of this <code>JRectangle</code>
        // to match the specified <code>JRectangle</code>.
        // <p>
        // This method is included for completeness, to parallel the
        // <code>setBounds</code> method of <code>Component</code>.
        // @param r the specified <code>JRectangle</code>
        // @see       #getBounds
        // @see       java.awt.Component#setBounds(java.awt.JRectangle)
        // @since     1.1
        //
        public void SetBounds(JRectangle r) {
            SetBounds(r.X, r.Y, r.Width, r.Height);
        }

        //
        // Summary
        // Sets the bounding <code>JRectangle</code> of this
        // <code>JRectangle</code> to the specified
        // <code>X</code>, <code>Y</code>, <code>Width</code>,
        // and <code>Height</code>.
        // <p>
        // This method is included for completeness, to parallel the
        // <code>setBounds</code> method of <code>Component</code>.
        // @param X the new X coordinate for the upper-left
        //                    corner of this <code>JRectangle</code>
        // @param Y the new Y coordinate for the upper-left
        //                    corner of this <code>JRectangle</code>
        // @param Width the new Width for this <code>JRectangle</code>
        // @param Height the new Height for this <code>JRectangle</code>
        // @see       #getBounds
        // @see       java.awt.Component#setBounds(int, int, int, int)
        // @since     1.1
        //
        public void SetBounds(int X, int Y, int Width, int Height) {
            SetBounds(X, Y, Width, Height);
        }

        //
        // Summary
        // Sets the bounds of this {@code JRectangle} to the integer bounds
        // which encompass the specified {@code X}, {@code Y}, {@code Width},
        // and {@code Height}.
        // If the parameters specify a {@code JRectangle} that exceeds the
        // maximum range of integers, the result will be the best
        // representation of the specified {@code JRectangle} intersected
        // with the maximum integer bounds.
        // @param X the X coordinate of the upper-left corner of
        //                  the specified JRectangle
        // @param Y the Y coordinate of the upper-left corner of
        //                  the specified JRectangle
        // @param Width the Width of the specified JRectangle
        // @param Height the new Height of the specified JRectangle
        //
        public void SetRect(double x, double y, double width, double height) {
            int newx, newy, neww, newh;

            if (x > 2.0 * int.MaxValue) {
                // Too far in positive X direction to represent...
                // We cannot even reach the left side of the specified
                // JRectangle even with both X & Width set to MAX_VALUE.
                // The intersection with the "maximal integer JRectangle"
                // is non-existent so we should use a Width < 0.
                // REMIND: Should we try to determine a more "meaningful"
                // adjusted value for newW than just "-1"?
                newx = int.MaxValue;
                neww = -1;
            } else {
                newx = Clip(x, false);
                if (width >= 0) width += x - newx;
                neww = Clip(width, width >= 0);
            }

            if (y > 2.0 * int.MaxValue) {
                // Too far in positive Y direction to represent...
                newy = int.MaxValue;
                newh = -1;
            } else {
                newy = Clip(y, false);
                if (height >= 0) height += y - newy;
                newh = Clip(height, height >= 0);
            }

            SetBounds(newx, newy, neww, newh);
        }

        // Return best integer representation for v, clipped to integer
        // range and floor-ed or ceiling-ed, depending on the boolean.
        private static int Clip(double v, bool doceil) {
            if (v <= int.MinValue) {
                return int.MinValue;
            }
            if (v >= int.MaxValue) {
                return int.MaxValue;
            }
            return (int)(doceil ? Math.Ceiling(v) : Math.Floor(v));
        }

        //
        // Summary
        // Returns the location of this <code>JRectangle</code>.
        // <p>
        // This method is included for completeness, to parallel the
        // <code>getLocation</code> method of <code>Component</code>.
        // @return the <code>Point</code> that is the upper-left corner of
        //                  this <code>JRectangle</code>.
        // @see       java.awt.Component#getLocation
        // @see       #setLocation(Point)
        // @see       #setLocation(int, int)
        // @since     1.1
        //
        public Point GetLocation() {
            return new Point(X, Y);
        }

        //
        // Summary
        // Moves this <code>JRectangle</code> to the specified location.
        // <p>
        // This method is included for completeness, to parallel the
        // <code>setLocation</code> method of <code>Component</code>.
        // @param p the <code>Point</code> specifying the new location
        //                for this <code>JRectangle</code>
        // @see       java.awt.Component#setLocation(java.awt.Point)
        // @see       #getLocation
        // @since     1.1
        //
        public void SetLocation(Point p) {
            SetLocation(p.X, p.Y);
        }

        //
        // Summary
        // Moves this <code>JRectangle</code> to the specified location.
        // <p>
        // This method is included for completeness, to parallel the
        // <code>setLocation</code> method of <code>Component</code>.
        // @param X the X coordinate of the new location
        // @param Y the Y coordinate of the new location
        // @see       #getLocation
        // @see       java.awt.Component#setLocation(int, int)
        // @since     1.1
        //
        public void SetLocation(int x, int y) {
            this.X = x;
            this.Y = y;
        }

        //
        // Summary
        // Translates this <code>JRectangle</code> the indicated distance,
        // to the right along the X coordinate axis, and
        // downward along the Y coordinate axis.
        // @param dx the distance to move this <code>JRectangle</code>
        //                 along the X axis
        // @param dy the distance to move this <code>JRectangle</code>
        //                 along the Y axis
        // @see       java.awt.JRectangle#setLocation(int, int)
        // @see       java.awt.JRectangle#setLocation(java.awt.Point)
        //
        public void Translate(int dx, int dy) {
            int oldv = this.X;
            int newv = oldv + dx;
            if (dx < 0) {
                // moving leftward
                if (newv > oldv) {
                    // negative overflow
                    // Only adjust Width if it was valid (>= 0).
                    if (Width >= 0) {
                        // The right edge is now conceptually at
                        // newV+Width, but we may move newV to prevent
                        // overflow.  But we want the right edge to
                        // remain at its new location in spite of the
                        // clipping.  Think of the following adjustment
                        // conceptually the same as:
                        // Width += newV; newV = MIN_VALUE; Width -= newV;
                        Width += newv - int.MinValue;
                        // Width may go negative if the right edge went past
                        // MIN_VALUE, but it cannot overflow since it cannot
                        // have moved more than MIN_VALUE and any non-negative
                        // number + MIN_VALUE does not overflow.
                    }
                    newv = int.MinValue;
                }
            } else {
                // moving rightward (or staying still)
                if (newv < oldv) {
                    // positive overflow
                    if (Width >= 0) {
                        // Conceptually the same as:
                        // Width += newV; newV = MAX_VALUE; Width -= newV;
                        Width += newv - int.MaxValue;
                        // With large widths and large displacements
                        // we may overflow so we need to check it.
                        if (Width < 0) Width = int.MaxValue;
                    }
                    newv = int.MaxValue;
                }
            }
            this.X = newv;

            oldv = this.Y;
            newv = oldv + dy;
            if (dy < 0) {
                // moving upward
                if (newv > oldv) {
                    // negative overflow
                    if (Height >= 0) {
                        Height += newv - int.MinValue;
                        // See above comment about no overflow in this case
                    }
                    newv = int.MinValue;
                }
            } else {
                // moving downward (or staying still)
                if (newv < oldv) {
                    // positive overflow
                    if (Height >= 0) {
                        Height += newv - int.MaxValue;
                        if (Height < 0) Height = int.MaxValue;
                    }
                    newv = int.MaxValue;
                }
            }
            this.Y = newv;
        }

        //
        // Summary
        // Gets the size of this <code>JRectangle</code>, represented by
        // the returned <code>Size</code>.
        // <p>
        // This method is included for completeness, to parallel the
        // <code>getSize</code> method of <code>Component</code>.
        // @return a <code>Size</code>, representing the size of
        //            this <code>JRectangle</code>.
        // @see       java.awt.Component#getSize
        // @see       #setSize(Size)
        // @see       #setSize(int, int)
        // @since     1.1
        //
        public Size GetSize() {
            return new Size(Width, Height);
        }

        //
        // Summary
        // Sets the size of this <code>JRectangle</code> to match the
        // specified <code>Size</code>.
        // <p>
        // This method is included for completeness, to parallel the
        // <code>setSize</code> method of <code>Component</code>.
        // @param d the new size for the <code>Size</code> object
        // @see       java.awt.Component#setSize(java.awt.Size)
        // @see       #getSize
        // @since     1.1
        //
        public void SetSize(Size d) {
            SetSize(d.Width, d.Height);
        }

        //
        // Summary
        // Sets the size of this <code>JRectangle</code> to the specified
        // Width and Height.
        // <p>
        // This method is included for completeness, to parallel the
        // <code>setSize</code> method of <code>Component</code>.
        // @param Width the new Width for this <code>JRectangle</code>
        // @param Height the new Height for this <code>JRectangle</code>
        // @see       java.awt.Component#setSize(int, int)
        // @see       #getSize
        // @since     1.1
        //
        public void SetSize(int width, int Height) {
            this.Width = width;
            this.Height = Height;
        }

        //
        // Summary
        // Checks whether or not this <code>JRectangle</code> contains the
        // specified <code>Point</code>.
        // @param p the <code>Point</code> to test
        // @return    <code>true</code> if the specified <code>Point</code>
        //            is inside this <code>JRectangle</code>;
        //            <code>false</code> otherwise.
        // @since     1.1
        //
        public bool Contains(Point p) {
            return Contains(p.X, p.Y);
        }

        //
        // Summary
        // Checks whether or not this <code>JRectangle</code> contains the
        // point at the specified location {@code (X,Y)}.
        //
        // @param  X the specified X coordinate
        // @param  Y the specified Y coordinate
        // @return    <code>true</code> if the point
        //            {@code (X,Y)} is inside this
        //            <code>JRectangle</code>;
        //            <code>false</code> otherwise.
        // @since     1.1
        //
        public bool Contains(int X, int Y) {
            return Inside(X, Y);
        }

        //
        // Summary
        // Checks whether or not this <code>JRectangle</code> entirely contains
        // the specified <code>JRectangle</code>.
        //
        // @param     r   the specified <code>JRectangle</code>
        // @return    <code>true</code> if the <code>JRectangle</code>
        //            is contained entirely inside this <code>JRectangle</code>;
        //            <code>false</code> otherwise
        // @since     1.2
        //
        public bool Contains(JRectangle r) {
            return Contains(r.X, r.Y, r.Width, r.Height);
        }

        //
        // Summary
        // Checks whether this <code>JRectangle</code> entirely contains
        // the <code>JRectangle</code>
        // at the specified location {@code (X,Y)} with the
        // specified Sizes {@code (W,H)}.
        // @param     X the specified X coordinate
        // @param     Y the specified Y coordinate
        // @param     W   the Width of the <code>JRectangle</code>
        // @param     H   the Height of the <code>JRectangle</code>
        // @return    <code>true</code> if the <code>JRectangle</code> specified by
        //            {@code (X, Y, W, H)}
        //            is entirely enclosed inside this <code>JRectangle</code>;
        //            <code>false</code> otherwise.
        // @since     1.1
        //
        public bool Contains(int X, int Y, int W, int H) {
            int w = this.Width;
            int h = this.Height;
            if ((w | h | W | H) < 0) {
                // At least one of the Sizes is negative...
                return false;
            }
            // Note: if any Size is zero, tests below must return false...
            int x = this.X;
            int y = this.Y;
            if (X < x || Y < y) {
                return false;
            }
            w += X;
            W += X;
            if (W <= X) {
                // X+W overflowed or W was zero, return false if...
                // either original w or W was zero or
                // X+w did not overflow or
                // the overflowed X+w is smaller than the overflowed X+W
                if (w >= x || W > w) return false;
            } else {
                // X+W did not overflow and W was not zero, return false if...
                // original w was zero or
                // X+w did not overflow and X+w is smaller than X+W
                if (w >= x && W > w) return false;
            }
            h += Y;
            H += Y;
            if (H <= Y) {
                if (h >= y || H > h) return false;
            } else {
                if (h >= y && H > h) return false;
            }
            return true;
        }

        public bool Inside(int X, int Y) {
            int w = this.Width;
            int h = this.Height;
            if ((w | h) < 0) {
                // At least one of the dimensions is negative...
                return false;
            }
            // Note: if either dimension is zero, tests below must return false...
            int x = this.X;
            int y = this.Y;
            if (X < x || Y < y) {
                return false;
            }
            w += x;
            h += y;
            //    overflow || intersect
            return ((w < x || w > X) &&
                    (h < y || h > Y));
        }

        //
        // Summary
        // Determines whether or not this <code>JRectangle</code> and the specified
        // <code>JRectangle</code> intersect. Two rectangles intersect if
        // their intersection is nonempty.
        //
        // @param r the specified <code>JRectangle</code>
        // @return    <code>true</code> if the specified <code>JRectangle</code>
        //            and this <code>JRectangle</code> intersect;
        //            <code>false</code> otherwise.
        //
        public bool Intersects(JRectangle r) {
            int tw = this.Width;
            int th = this.Height;
            int rw = r.Width;
            int rh = r.Height;
            if (rw <= 0 || rh <= 0 || tw <= 0 || th <= 0) {
                return false;
            }
            int tx = this.X;
            int ty = this.Y;
            int rx = r.X;
            int ry = r.Y;
            rw += rx;
            rh += ry;
            tw += tx;
            th += ty;
            //      overflow || intersect
            return ((rw < rx || rw > tx) &&
                    (rh < ry || rh > ty) &&
                    (tw < tx || tw > rx) &&
                    (th < ty || th > ry));
        }

        //
        // Summary
        // Computes the intersection of this <code>JRectangle</code> with the
        // specified <code>JRectangle</code>. Returns a new <code>JRectangle</code>
        // that represents the intersection of the two rectangles.
        // If the two rectangles do not intersect, the result will be
        // an empty JRectangle.
        //
        // @param     r   the specified <code>JRectangle</code>
        // @return    the largest <code>JRectangle</code> contained in both the
        //            specified <code>JRectangle</code> and in
        //            this <code>JRectangle</code>; or if the rectangles
        //            do not intersect, an empty JRectangle.
        //
        public JRectangle Intersection(JRectangle r) {
            int tx1 = this.X;
            int ty1 = this.Y;
            int rx1 = r.X;
            int ry1 = r.Y;
            long tx2 = tx1; tx2 += this.Width;
            long ty2 = ty1; ty2 += this.Height;
            long rx2 = rx1; rx2 += r.Width;
            long ry2 = ry1; ry2 += r.Height;
            if (tx1 < rx1) tx1 = rx1;
            if (ty1 < ry1) ty1 = ry1;
            if (tx2 > rx2) tx2 = rx2;
            if (ty2 > ry2) ty2 = ry2;
            tx2 -= tx1;
            ty2 -= ty1;
            // tx2,ty2 will never overflow (they will never be
            // larger than the smallest of the two source w,h)
            // they might underflow, though...
            if (tx2 < int.MinValue) tx2 = int.MinValue;
            if (ty2 < int.MinValue) ty2 = int.MinValue;
            return new JRectangle(tx1, ty1, (int)tx2, (int)ty2);
        }

        //
        // Summary
        // Computes the union of this <code>JRectangle</code> with the
        // specified <code>JRectangle</code>. Returns a new
        // <code>JRectangle</code> that
        // represents the union of the two rectangles.
        // <p>
        // If either {@code JRectangle} has any Size less than zero
        // the rules for <a href=#NonExistant>non-existent</a> rectangles
        // apply.
        // If only one has a Size less than zero, then the result
        // will be a copy of the other {@code JRectangle}.
        // If both have Size less than zero, then the result will
        // have at least one Size less than zero.
        // <p>
        // If the resulting {@code JRectangle} would have a Size
        // too large to be expressed as an {@code int}, the result
        // will have a Size of {@code int.MaxValue} along
        // that Size.
        // @param r the specified <code>JRectangle</code>
        // @return    the smallest <code>JRectangle</code> containing both
        //            the specified <code>JRectangle</code> and this
        //            <code>JRectangle</code>.
        //
        public JRectangle Union(JRectangle r) {
            long tx2 = this.Width;
            long ty2 = this.Height;
            if ((tx2 | ty2) < 0) {
                // This JRectangle has negative Sizes...
                // If r has non-negative Sizes then it is the answer.
                // If r is non-existent (has a negative Size), then both
                // are non-existent and we can return any non-existent JRectangle
                // as an answer.  Thus, returning r meets that criterion.
                // Either way, r is our answer.
                return new JRectangle(r);
            }
            long rx2 = r.Width;
            long ry2 = r.Height;
            if ((rx2 | ry2) < 0) {
                return new JRectangle(this);
            }
            int tx1 = this.X;
            int ty1 = this.Y;
            tx2 += tx1;
            ty2 += ty1;
            int rx1 = r.X;
            int ry1 = r.Y;
            rx2 += rx1;
            ry2 += ry1;
            if (tx1 > rx1) tx1 = rx1;
            if (ty1 > ry1) ty1 = ry1;
            if (tx2 < rx2) tx2 = rx2;
            if (ty2 < ry2) ty2 = ry2;
            tx2 -= tx1;
            ty2 -= ty1;
            // tx2,ty2 will never underflow since both original rectangles
            // were already proven to be non-empty
            // they might overflow, though...
            if (tx2 > int.MaxValue) tx2 = int.MaxValue;
            if (ty2 > int.MaxValue) ty2 = int.MaxValue;
            return new JRectangle(tx1, ty1, (int)tx2, (int)ty2);
        }

        //
        // Summary
        // Adds a point, specified by the integer arguments {@code newX,newY}
        // to the bounds of this {@code JRectangle}.
        // <p>
        // If this {@code JRectangle} has any Size less than zero,
        // the rules for <a href=#NonExistant>non-existent</a>
        // rectangles apply.
        // In that case, the new bounds of this {@code JRectangle} will
        // have a location equal to the specified coordinates and
        // Width and Height equal to zero.
        // <p>
        // After adding a point, a call to <code>contains</code> with the
        // added point as an argument does not necessarily return
        // <code>true</code>. The <code>contains</code> method does not
        // return <code>true</code> for points on the right or bottom
        // edges of a <code>JRectangle</code>. Therefore, if the added point
        // falls on the right or bottom edge of the enlarged
        // <code>JRectangle</code>, <code>contains</code> returns
        // <code>false</code> for that point.
        // If the specified point must be contained within the new
        // {@code JRectangle}, a 1x1 JRectangle should be added instead:
        // <pre>
        //     r.add(newX, newY, 1, 1);
        // </pre>
        // @param newX the X coordinate of the new point
        // @param newY the Y coordinate of the new point
        //
        public void Add(int newx, int newy) {
            if ((Width | Height) < 0) {
                this.X = newx;
                this.Y = newy;
                this.Width = this.Height = 0;
                return;
            }
            int x1 = this.X;
            int y1 = this.Y;
            long x2 = this.Width;
            long y2 = this.Height;
            x2 += x1;
            y2 += y1;
            if (x1 > newx) x1 = newx;
            if (y1 > newy) y1 = newy;
            if (x2 < newx) x2 = newx;
            if (y2 < newy) y2 = newy;
            x2 -= x1;
            y2 -= y1;
            if (x2 > int.MaxValue) x2 = int.MaxValue;
            if (y2 > int.MaxValue) y2 = int.MaxValue;
            SetBounds(x1, y1, (int)x2, (int)y2);
        }

        //
        // Summary
        // Adds the specified {@code Point} to the bounds of this
        // {@code JRectangle}.
        // <p>
        // If this {@code JRectangle} has any Size less than zero,
        // the rules for <a href=#NonExistant>non-existent</a>
        // rectangles apply.
        // In that case, the new bounds of this {@code JRectangle} will
        // have a location equal to the coordinates of the specified
        // {@code Point} and Width and Height equal to zero.
        // <p>
        // After adding a <code>Point</code>, a call to <code>contains</code>
        // with the added <code>Point</code> as an argument does not
        // necessarily return <code>true</code>. The <code>contains</code>
        // method does not return <code>true</code> for points on the right
        // or bottom edges of a <code>JRectangle</code>. Therefore if the added
        // <code>Point</code> falls on the right or bottom edge of the
        // enlarged <code>JRectangle</code>, <code>contains</code> returns
        // <code>false</code> for that <code>Point</code>.
        // If the specified point must be contained within the new
        // {@code JRectangle}, a 1x1 JRectangle should be added instead:
        // <pre>
        //     r.add(pt.X, pt.Y, 1, 1);
        // </pre>
        // @param pt the new <code>Point</code> to add to this
        //           <code>JRectangle</code>
        //
        public void Add(Point pt) {
            Add(pt.X, pt.Y);
        }

        //
        // Summary
        // Adds a <code>JRectangle</code> to this <code>JRectangle</code>.
        // The resulting <code>JRectangle</code> is the union of the two
        // rectangles.
        // <p>
        // If either {@code JRectangle} has any Size less than 0, the
        // result will have the Sizes of the other {@code JRectangle}.
        // If both {@code JRectangle}s have at least one Size less
        // than 0, the result will have at least one Size less than 0.
        // <p>
        // If either {@code JRectangle} has one or both Sizes equal
        // to 0, the result along those axes with 0 Sizes will be
        // equivalent to the results obtained by adding the corresponding
        // origin coordinate to the result JRectangle along that axis,
        // similar to the operation of the {@link #add(Point)} method,
        // but contribute no further Size beyond that.
        // <p>
        // If the resulting {@code JRectangle} would have a Size
        // too large to be expressed as an {@code int}, the result
        // will have a Size of {@code int.MaxValue} along
        // that Size.
        // @param  r the specified <code>JRectangle</code>
        //
        public void Add(JRectangle r) {
            long tx2 = this.Width;
            long ty2 = this.Height;
            if ((tx2 | ty2) < 0) {
                SetBounds(r.X, r.Y, r.Width, r.Height);
            }
            long rx2 = r.Width;
            long ry2 = r.Height;
            if ((rx2 | ry2) < 0) {
                return;
            }
            int tx1 = this.X;
            int ty1 = this.Y;
            tx2 += tx1;
            ty2 += ty1;
            int rx1 = r.X;
            int ry1 = r.Y;
            rx2 += rx1;
            ry2 += ry1;
            if (tx1 > rx1) tx1 = rx1;
            if (ty1 > ry1) ty1 = ry1;
            if (tx2 < rx2) tx2 = rx2;
            if (ty2 < ry2) ty2 = ry2;
            tx2 -= tx1;
            ty2 -= ty1;
            // tx2,ty2 will never underflow since both original
            // rectangles were non-empty
            // they might overflow, though...
            if (tx2 > int.MaxValue) tx2 = int.MaxValue;
            if (ty2 > int.MaxValue) ty2 = int.MaxValue;
            SetBounds(tx1, ty1, (int)tx2, (int)ty2);
        }

        //
        // Summary
        // Resizes the <code>JRectangle</code> both horizontally and vertically.
        // <p>
        // This method modifies the <code>JRectangle</code> so that it is
        // <code>h</code> units larger on both the left and right side,
        // and <code>v</code> units larger at both the top and bottom.
        // <p>
        // The new <code>JRectangle</code> has {@code (X - h, Y - v)}
        // as its upper-left corner,
        // Width of {@code (Width + 2h)},
        // and a Height of {@code (Height + 2v)}.
        // <p>
        // If negative values are supplied for <code>h</code> and
        // <code>v</code>, the size of the <code>JRectangle</code>
        // decreases accordingly.
        // The {@code grow} method will check for integer overflow
        // and underflow, but does not check whether the resulting
        // values of {@code Width} and {@code Height} grow
        // from negative to non-negative or shrink from non-negative
        // to negative.
        // @param h the horizontal expansion
        // @param v the vertical expansion
        //
        public void Grow(int h, int v) {
            long x0 = this.X;
            long y0 = this.Y;
            long x1 = this.Width;
            long y1 = this.Height;
            x1 += x0;
            y1 += y0;

            x0 -= h;
            y0 -= v;
            x1 += h;
            y1 += v;

            if (x1 < x0) {
                // Non-existent in X direction
                // Final Width must remain negative so subtract x0 before
                // it is clipped so that we avoid the risk that the clipping
                // of x0 will reverse the ordering of x0 and x1.
                x1 -= x0;
                if (x1 < int.MinValue) x1 = int.MinValue;
                if (x0 < int.MinValue) x0 = int.MinValue;
                else if (x0 > int.MaxValue) x0 = int.MaxValue;
            } else { // (x1 >= x0)
                     // Clip x0 before we subtract it from x1 in case the clipping
                     // affects the representable area of the JRectangle.
                if (x0 < int.MinValue) x0 = int.MinValue;
                else if (x0 > int.MaxValue) x0 = int.MaxValue;
                x1 -= x0;
                // The only way x1 can be negative now is if we clipped
                // x0 against MIN and x1 is less than MIN - in which case
                // we want to leave the Width negative since the result
                // did not intersect the representable area.
                if (x1 < int.MinValue) x1 = int.MinValue;
                else if (x1 > int.MaxValue) x1 = int.MaxValue;
            }

            if (y1 < y0) {
                // Non-existent in Y direction
                y1 -= y0;
                if (y1 < int.MinValue) y1 = int.MinValue;
                if (y0 < int.MinValue) y0 = int.MinValue;
                else if (y0 > int.MaxValue) y0 = int.MaxValue;
            } else { // (y1 >= y0)
                if (y0 < int.MinValue) y0 = int.MinValue;
                else if (y0 > int.MaxValue) y0 = int.MaxValue;
                y1 -= y0;
                if (y1 < int.MinValue) y1 = int.MinValue;
                else if (y1 > int.MaxValue) y1 = int.MaxValue;
            }

            SetBounds((int)x0, (int)y0, (int)x1, (int)y1);
        }

        //
        // Summary
        // {@inheritDoc}
        // @since 1.2
        //
        public bool IsEmpty() {
            return (Width <= 0) || (Height <= 0);
        }
    }
}