﻿namespace NetEscapades.AspNetCore.SecurityHeaders.Infrastructure
{
    /// <summary>
    /// The form-action directive restricts the URLs which can be used as the target of a form submissions from a given context
    /// </summary>
    public class FormActionDirectiveBuilder :CspDirectiveBuilder
    {
        public FormActionDirectiveBuilder(): base("form-action")
        {
        }
    }
}