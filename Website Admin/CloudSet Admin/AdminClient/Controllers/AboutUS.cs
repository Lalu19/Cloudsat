using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class AboutUS : Controller
    {
        public IActionResult AboutUScreate()
        {
            ViewBag.tools = new[] { "Bold", "Italic", "Underline", "StrikeThrough",
                "FontName", "FontSize", "FontColor", "BackgroundColor",
                "LowerCase", "UpperCase","SuperScript", "SubScript", "|",
                "Formats", "Alignments", "NumberFormatList", "BulletFormatList",
                "Outdent", "Indent", "|",
                "CreateTable", "CreateLink", "Image", "FileManager", "|", "ClearFormat", "Print",
                "SourceCode", "FullScreen", "|", "Undo", "Redo" };
            ViewBag.table = new[] {
                "TableHeader", "TableRows", "TableColumns", "TableCell", "-", "BackgroundColor", "TableRemove", "TableCellVerticalAlign", "Styles"
            };
            return View();
        }

        public IActionResult AboutUSList()
        {
            return View();
        }
        public IActionResult AboutUSEdit(int aboutUsId)
        {
            ViewBag.tools = new[] { "Bold", "Italic", "Underline", "StrikeThrough",
                "FontName", "FontSize", "FontColor", "BackgroundColor",
                "LowerCase", "UpperCase","SuperScript", "SubScript", "|",
                "Formats", "Alignments", "NumberFormatList", "BulletFormatList",
                "Outdent", "Indent", "|",
                "CreateTable", "CreateLink", "Image", "FileManager", "|", "ClearFormat", "Print",
                "SourceCode", "FullScreen", "|", "Undo", "Redo" };
            ViewBag.table = new[] {
                "TableHeader", "TableRows", "TableColumns", "TableCell", "-", "BackgroundColor", "TableRemove", "TableCellVerticalAlign", "Styles"
            };
            ViewBag.aboutUsId = aboutUsId;
            return View();
        }
    }
}
