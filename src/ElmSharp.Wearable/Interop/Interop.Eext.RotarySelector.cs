﻿using System;
using System.Runtime.InteropServices;


internal static partial class Interop
{
    internal static partial class Eext
    {
        [DllImport(Libraries.Eext)]
        internal static extern IntPtr eext_rotary_selector_add(IntPtr parent);
        [DllImport(Libraries.Eext)]
        internal static extern IntPtr eext_rotary_selector_item_append(IntPtr obj);
        [DllImport(Libraries.Eext)]
        internal static extern IntPtr eext_rotary_selector_item_prepend(IntPtr obj);
        [DllImport(Libraries.Eext)]
        internal static extern IntPtr eext_rotary_selector_item_insert_after(IntPtr obj, IntPtr after);
        [DllImport(Libraries.Eext)]
        internal static extern IntPtr eext_rotary_selector_item_insert_before(IntPtr obj, IntPtr before);
        [DllImport(Libraries.Eext)]
        internal static extern void eext_rotary_selector_item_del(IntPtr item);
        [DllImport(Libraries.Eext)]
        internal static extern void eext_rotary_selector_items_clear(IntPtr obj);
        [DllImport(Libraries.Eext)]
        internal static extern void eext_rotary_selector_item_part_text_set(IntPtr item, string part_name, string text);
        [DllImport(Libraries.Eext)]
        internal static extern string eext_rotary_selector_item_part_text_get(IntPtr item, string part_name);
        [DllImport(Libraries.Eext)]
        internal static extern void eext_rotary_selector_item_domain_translatable_part_text_set(IntPtr item, string part_name, string domain, string text);
        [DllImport(Libraries.Eext)]
        internal static extern void eext_rotary_selector_item_part_content_set(IntPtr item, string part_name, int state, IntPtr content);
        [DllImport(Libraries.Eext)]
        internal static extern IntPtr eext_rotary_selector_item_part_content_get(IntPtr item, string part_name, int state);
        [DllImport(Libraries.Eext)]
        internal static extern void eext_rotary_selector_part_content_set(IntPtr obj, string part_name, int state, IntPtr content);
        [DllImport(Libraries.Eext)]
        internal static extern IntPtr eext_rotary_selector_part_content_get(IntPtr obj, string part_name, int state);
        [DllImport(Libraries.Eext)]
        internal static extern void eext_rotary_selector_item_part_color_set(IntPtr item, string part_name, int state, int r, int g, int b, int a);
        [DllImport(Libraries.Eext)]
        internal static extern void eext_rotary_selector_item_part_color_get(IntPtr item, string part_name, int state, out int r, out int g, out int b, out int a);
        [DllImport(Libraries.Eext)]
        internal static extern void eext_rotary_selector_part_color_set(IntPtr obj, string part_name, int state, int r, int g, int b, int a);
        [DllImport(Libraries.Eext)]
        internal static extern void eext_rotary_selector_part_color_get(IntPtr obj, string part_name, int state, out int r, out int g, out int b, out int a);
        [DllImport(Libraries.Eext)]
        internal static extern void eext_rotary_selector_selected_item_set(IntPtr obj, IntPtr item);
        [DllImport(Libraries.Eext)]
        internal static extern IntPtr eext_rotary_selector_selected_item_get(IntPtr obj);

    }
}
