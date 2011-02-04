﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cecil.Decompiler.Ast;
using System.ComponentModel.Composition;

namespace Monoflector.Interface
{
    /// <summary>
    /// Represents an AST presenter.
    /// </summary>
    [InheritedExport(typeof(IAstPresenter))]
    public interface IAstPresenter
    {
        /// <summary>
        /// Presents the specified node.
        /// </summary>
        /// <param name="node">The node.</param>
        void Present(ICodeNode node);
    }
}
