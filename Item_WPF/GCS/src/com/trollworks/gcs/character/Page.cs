///*
// * Copyright (c) 1998-2016 by Richard A. Wilkes. All rights reserved.
// *
// * This Source Code Form is subject to the terms of the Mozilla Public License,
// * version 2.0. If a copy of the MPL was not distributed with this file, You
// * can obtain one at http://mozilla.org/MPL/2.0/.
// *
// * This Source Code Form is "Incompatible With Secondary Licenses", as defined
// * by the Mozilla Public License, version 2.0.
// */

//package com.trollworks.gcs.character;

//using com.trollworks.toolkit.ui.GraphicsUtilities;
//using com.trollworks.toolkit.ui.UIUtilities;
//using com.trollworks.toolkit.ui.print.PrintManager;
//using com.trollworks.toolkit.utility.units.LengthUnits;

//using java.awt.BorderLayout;
//using java.awt.Color;
//using java.awt.Dimension;
//using java.awt.Graphics;
//using java.awt.Insets;

//using javax.swing.JPanel;
//using javax.swing.border.EmptyBorder;

///** A printer page. */
//public class Page extends JPanel {
//	private PageOwner mOwner;

//	/**
//	 * Creates a new page.
//	 * 
//	 * @param owner The page owner.
//	 */
//	public Page(PageOwner owner) {
//		super(new BorderLayout());
//		mOwner = owner;
//		setOpaque(true);
//		setBackground(Color.white);
//		PrintManager pageSettings = mOwner.getPageSettings();
//		Insets insets = mOwner.getPageAdornmentsInsets(this);
//		double[] size = pageSettings != null ? pageSettings.getPageSize(LengthUnits.PT) : new double[] { 8.5 * 72.0, 11.0 * 72.0 };
//		double[] margins = pageSettings != null ? pageSettings.getPageMargins(LengthUnits.PT) : new double[] { 36.0, 36.0, 36.0, 36.0 };
//		setBorder(new EmptyBorder(insets.top + (int) margins[0], insets.left + (int) margins[1], insets.bottom + (int) margins[2], insets.right + (int) margins[3]));
//		Dimension pageSize = new Dimension((int) size[0], (int) size[1]);
//		UIUtilities.setOnlySize(this, pageSize);
//		setSize(pageSize);
//	}

//	@Override
//	protected void paintComponent(Graphics gc) {
//		super.paintComponent(GraphicsUtilities.prepare(gc));
//		mOwner.drawPageAdornments(this, gc);
//	}
//}
