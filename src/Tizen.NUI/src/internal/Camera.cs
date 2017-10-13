/*
 * Copyright(c) 2017 Samsung Electronics Co., Ltd.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

namespace Tizen.NUI
{

    internal class Camera : Animatable
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal Camera(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicPINVOKE.CameraActor_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Camera obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        protected override void Dispose(DisposeTypes type)
        {
            if (disposed)
            {
                return;
            }

            if (type == DisposeTypes.Explicit)
            {
                //Called by User
                //Release your own managed resources here.
                //You should release all of your own disposable objects here.

            }

            //Release your own unmanaged resources here.
            //You should not access any managed member here except static instance.
            //because the execution order of Finalizes is non-deterministic.

            if (swigCPtr.Handle != global::System.IntPtr.Zero)
            {
                if (swigCMemOwn)
                {
                    swigCMemOwn = false;
                    NDalicPINVOKE.delete_CameraActor(swigCPtr);
                }
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
            }

            base.Dispose(type);
        }



        public class Property : global::System.IDisposable
        {
            private global::System.Runtime.InteropServices.HandleRef swigCPtr;
            protected bool swigCMemOwn;

            internal Property(global::System.IntPtr cPtr, bool cMemoryOwn)
            {
                swigCMemOwn = cMemoryOwn;
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
            }

            internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Property obj)
            {
                return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
            }

            //A Flag to check who called Dispose(). (By User or DisposeQueue)
            private bool isDisposeQueued = false;
            //A Flat to check if it is already disposed.
            protected bool disposed = false;

            ~Property()
            {
                if (!isDisposeQueued)
                {
                    isDisposeQueued = true;
                    DisposeQueue.Instance.Add(this);
                }
            }

            public void Dispose()
            {
                //Throw excpetion if Dispose() is called in separate thread.
                if (!Window.IsInstalled())
                {
                    throw new System.InvalidOperationException("This API called from separate thread. This API must be called from MainThread.");
                }

                if (isDisposeQueued)
                {
                    Dispose(DisposeTypes.Implicit);
                }
                else
                {
                    Dispose(DisposeTypes.Explicit);
                    System.GC.SuppressFinalize(this);
                }
            }

            protected virtual void Dispose(DisposeTypes type)
            {
                if (disposed)
                {
                    return;
                }

                if (type == DisposeTypes.Explicit)
                {
                    //Called by User
                    //Release your own managed resources here.
                    //You should release all of your own disposable objects here.

                }

                //Release your own unmanaged resources here.
                //You should not access any managed member here except static instance.
                //because the execution order of Finalizes is non-deterministic.

                if (swigCPtr.Handle != global::System.IntPtr.Zero)
                {
                    if (swigCMemOwn)
                    {
                        swigCMemOwn = false;
                        NDalicPINVOKE.delete_CameraActor_Property(swigCPtr);
                    }
                    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
                }

                disposed = true;
            }


            public Property() : this(NDalicPINVOKE.new_CameraActor_Property(), true)
            {
                if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            }

            public static readonly int TYPE = NDalicPINVOKE.CameraActor_Property_TYPE_get();
            public static readonly int PROJECTION_MODE = NDalicPINVOKE.CameraActor_Property_PROJECTION_MODE_get();
            public static readonly int FIELD_OF_VIEW = NDalicPINVOKE.CameraActor_Property_FIELD_OF_VIEW_get();
            public static readonly int ASPECT_RATIO = NDalicPINVOKE.CameraActor_Property_ASPECT_RATIO_get();
            public static readonly int NEAR_PLANE_DISTANCE = NDalicPINVOKE.CameraActor_Property_NEAR_PLANE_DISTANCE_get();
            public static readonly int FAR_PLANE_DISTANCE = NDalicPINVOKE.CameraActor_Property_FAR_PLANE_DISTANCE_get();
            public static readonly int LEFT_PLANE_DISTANCE = NDalicPINVOKE.CameraActor_Property_LEFT_PLANE_DISTANCE_get();
            public static readonly int RIGHT_PLANE_DISTANCE = NDalicPINVOKE.CameraActor_Property_RIGHT_PLANE_DISTANCE_get();
            public static readonly int TOP_PLANE_DISTANCE = NDalicPINVOKE.CameraActor_Property_TOP_PLANE_DISTANCE_get();
            public static readonly int BOTTOM_PLANE_DISTANCE = NDalicPINVOKE.CameraActor_Property_BOTTOM_PLANE_DISTANCE_get();
            public static readonly int TARGET_POSITION = NDalicPINVOKE.CameraActor_Property_TARGET_POSITION_get();
            public static readonly int PROJECTION_MATRIX = NDalicPINVOKE.CameraActor_Property_PROJECTION_MATRIX_get();
            public static readonly int VIEW_MATRIX = NDalicPINVOKE.CameraActor_Property_VIEW_MATRIX_get();
            public static readonly int INVERT_Y_AXIS = NDalicPINVOKE.CameraActor_Property_INVERT_Y_AXIS_get();

        }

        public Camera() : this(NDalicPINVOKE.CameraActor_New__SWIG_0(), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

        }
        public Camera(Vector2 size) : this(NDalicPINVOKE.CameraActor_New__SWIG_1(Vector2.getCPtr(size)), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

        }
        public static Camera DownCast(BaseHandle handle)
        {
            Camera ret = Registry.GetManagedBaseHandleFromNativePtr(handle) as Camera;
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public Camera(Camera copy) : this(NDalicPINVOKE.new_CameraActor__SWIG_1(Camera.getCPtr(copy)), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public Camera Assign(Camera rhs)
        {
            Camera ret = new Camera(NDalicPINVOKE.CameraActor_Assign(swigCPtr, Camera.getCPtr(rhs)), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void SetType(CameraType type)
        {
            NDalicPINVOKE.CameraActor_SetType(swigCPtr, (int)type);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public new CameraType GetType()
        {
            CameraType ret = (CameraType)NDalicPINVOKE.CameraActor_GetType(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void SetProjectionMode(ProjectionMode mode)
        {
            NDalicPINVOKE.CameraActor_SetProjectionMode(swigCPtr, (int)mode);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public ProjectionMode GetProjectionMode()
        {
            ProjectionMode ret = (ProjectionMode)NDalicPINVOKE.CameraActor_GetProjectionMode(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void SetFieldOfView(float fieldOfView)
        {
            NDalicPINVOKE.CameraActor_SetFieldOfView(swigCPtr, fieldOfView);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public float GetFieldOfView()
        {
            float ret = NDalicPINVOKE.CameraActor_GetFieldOfView(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void SetAspectRatio(float aspectRatio)
        {
            NDalicPINVOKE.CameraActor_SetAspectRatio(swigCPtr, aspectRatio);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public float GetAspectRatio()
        {
            float ret = NDalicPINVOKE.CameraActor_GetAspectRatio(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void SetNearClippingPlane(float nearClippingPlane)
        {
            NDalicPINVOKE.CameraActor_SetNearClippingPlane(swigCPtr, nearClippingPlane);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public float GetNearClippingPlane()
        {
            float ret = NDalicPINVOKE.CameraActor_GetNearClippingPlane(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void SetFarClippingPlane(float farClippingPlane)
        {
            NDalicPINVOKE.CameraActor_SetFarClippingPlane(swigCPtr, farClippingPlane);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public float GetFarClippingPlane()
        {
            float ret = NDalicPINVOKE.CameraActor_GetFarClippingPlane(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void SetTargetPosition(Vector3 targetPosition)
        {
            NDalicPINVOKE.CameraActor_SetTargetPosition(swigCPtr, Vector3.getCPtr(targetPosition));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public Vector3 GetTargetPosition()
        {
            Vector3 ret = new Vector3(NDalicPINVOKE.CameraActor_GetTargetPosition(swigCPtr), true);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void SetInvertYAxis(bool invertYAxis)
        {
            NDalicPINVOKE.CameraActor_SetInvertYAxis(swigCPtr, invertYAxis);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public bool GetInvertYAxis()
        {
            bool ret = NDalicPINVOKE.CameraActor_GetInvertYAxis(swigCPtr);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        public void SetPerspectiveProjection(Vector2 size)
        {
            NDalicPINVOKE.CameraActor_SetPerspectiveProjection(swigCPtr, Vector2.getCPtr(size));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public void SetOrthographicProjection(Vector2 size)
        {
            NDalicPINVOKE.CameraActor_SetOrthographicProjection__SWIG_0(swigCPtr, Vector2.getCPtr(size));
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public void SetOrthographicProjection(float left, float right, float top, float bottom, float near, float far)
        {
            NDalicPINVOKE.CameraActor_SetOrthographicProjection__SWIG_1(swigCPtr, left, right, top, bottom, near, far);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        public string Type
        {
            get
            {
                string temp;
                GetProperty(Camera.Property.TYPE).Get(out temp);
                return temp;
            }
            set
            {
                SetProperty(Camera.Property.TYPE, new Tizen.NUI.PropertyValue(value));
            }
        }
        public string ProjectionMode
        {
            get
            {
                string temp;
                GetProperty(Camera.Property.PROJECTION_MODE).Get(out temp);
                return temp;
            }
            set
            {
                SetProperty(Camera.Property.PROJECTION_MODE, new Tizen.NUI.PropertyValue(value));
            }
        }
        public float FieldOfView
        {
            get
            {
                float temp = 0.0f;
                GetProperty(Camera.Property.FIELD_OF_VIEW).Get(out temp);
                return temp;
            }
            set
            {
                SetProperty(Camera.Property.FIELD_OF_VIEW, new Tizen.NUI.PropertyValue(value));
            }
        }
        public float AspectRatio
        {
            get
            {
                float temp = 0.0f;
                GetProperty(Camera.Property.ASPECT_RATIO).Get(out temp);
                return temp;
            }
            set
            {
                SetProperty(Camera.Property.ASPECT_RATIO, new Tizen.NUI.PropertyValue(value));
            }
        }
        public float NearPlaneDistance
        {
            get
            {
                float temp = 0.0f;
                GetProperty(Camera.Property.NEAR_PLANE_DISTANCE).Get(out temp);
                return temp;
            }
            set
            {
                SetProperty(Camera.Property.NEAR_PLANE_DISTANCE, new Tizen.NUI.PropertyValue(value));
            }
        }
        public float FarPlaneDistance
        {
            get
            {
                float temp = 0.0f;
                GetProperty(Camera.Property.FAR_PLANE_DISTANCE).Get(out temp);
                return temp;
            }
            set
            {
                SetProperty(Camera.Property.FAR_PLANE_DISTANCE, new Tizen.NUI.PropertyValue(value));
            }
        }
        public float LeftPlaneDistance
        {
            get
            {
                float temp = 0.0f;
                GetProperty(Camera.Property.LEFT_PLANE_DISTANCE).Get(out temp);
                return temp;
            }
            set
            {
                SetProperty(Camera.Property.LEFT_PLANE_DISTANCE, new Tizen.NUI.PropertyValue(value));
            }
        }
        public float RightPlaneDistance
        {
            get
            {
                float temp = 0.0f;
                GetProperty(Camera.Property.RIGHT_PLANE_DISTANCE).Get(out temp);
                return temp;
            }
            set
            {
                SetProperty(Camera.Property.RIGHT_PLANE_DISTANCE, new Tizen.NUI.PropertyValue(value));
            }
        }
        public float TopPlaneDistance
        {
            get
            {
                float temp = 0.0f;
                GetProperty(Camera.Property.TOP_PLANE_DISTANCE).Get(out temp);
                return temp;
            }
            set
            {
                SetProperty(Camera.Property.TOP_PLANE_DISTANCE, new Tizen.NUI.PropertyValue(value));
            }
        }
        public float BottomPlaneDistance
        {
            get
            {
                float temp = 0.0f;
                GetProperty(Camera.Property.BOTTOM_PLANE_DISTANCE).Get(out temp);
                return temp;
            }
            set
            {
                SetProperty(Camera.Property.BOTTOM_PLANE_DISTANCE, new Tizen.NUI.PropertyValue(value));
            }
        }
        public Vector3 TargetPosition
        {
            get
            {
                Vector3 temp = new Vector3(0.0f, 0.0f, 0.0f);
                GetProperty(Camera.Property.TARGET_POSITION).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(Camera.Property.TARGET_POSITION, new Tizen.NUI.PropertyValue(value));
            }
        }
        internal Matrix ProjectionMatrix
        {
            get
            {
                Matrix temp = new Matrix();
                GetProperty(Camera.Property.PROJECTION_MATRIX).Get(temp);
                return temp;
            }
        }
        internal Matrix ViewMatrix
        {
            get
            {
                Matrix temp = new Matrix();
                GetProperty(Camera.Property.VIEW_MATRIX).Get(temp);
                return temp;
            }
        }
        public bool InvertYAxis
        {
            get
            {
                bool temp = false;
                GetProperty(Camera.Property.INVERT_Y_AXIS).Get(out temp);
                return temp;
            }
            set
            {
                SetProperty(Camera.Property.INVERT_Y_AXIS, new Tizen.NUI.PropertyValue(value));
            }
        }

    }

}
