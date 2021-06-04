<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<xsl:template match="/">
		<HTML>
			<BODY>
				<xsl:apply-templates select="//name"/>
				<xsl:apply-templates select="//assembly"/>
			</BODY>
		</HTML>
	</xsl:template>

	<xsl:template match="name">
		<TABLE width="100%" border="0" cellspacing="0" cellpadding="10" bgcolor="lightskyblue">
			<TR>
				<TD align="center">
					<H1>
						<xsl:text>Assemblage : </xsl:text>
						<xsl:value-of select="." />
					</H1>
				</TD>
			</TR>
		</TABLE>
	</xsl:template>

	<xsl:template match="assembly">
		<xsl:apply-templates select="//member[contains(@name,'T:')]"/>
	</xsl:template>


	<xsl:template match="//member[contains(@name,'T:')]">
		<xsl:variable name="FullMemberName" select="substring-after(@name, ':')"/>
		<xsl:variable name="MemberName" select="substring-after(@name, '.')"/>

		<H2>
			Classe : <xsl:value-of select="$MemberName"/>
		</H2>
		<xsl:apply-templates/>

		<xsl:if test="//member[contains(@name,concat('F:',$FullMemberName))]">
			<H3>Champs :</H3>
			<TABLE width="100%" border="0" cellspacing="0" cellpadding="0">
				<xsl:for-each select="//member[contains(@name,concat('F:',$FullMemberName))]">
					<TR>
						<TD width="35px"></TD>
						<TD>
							<H4>
								<xsl:value-of select="substring-after(@name, concat('F:',$FullMemberName,'.'))"/>
							</H4>
							<xsl:apply-templates/>
						</TD>
					</TR>
				</xsl:for-each>
			</TABLE>
		</xsl:if>

		<xsl:if test="//member[contains(@name,concat('P:',$FullMemberName))]">
			<H3>Propriétés : </H3>
			<TABLE width="100%" border="0" cellspacing="0" cellpadding="0">
				<xsl:for-each select="//member[contains(@name,concat('P:',$FullMemberName))]">
					<TR>
						<TD width="35px"></TD>
						<TD>
							<H4>
								<xsl:value-of select="substring-after(@name, concat('P:',$FullMemberName,'.'))"/>
							</H4>
							<xsl:apply-templates/>
						</TD>
					</TR>
				</xsl:for-each>
			</TABLE>
		</xsl:if>

		<xsl:if test="//member[contains(@name,concat('M:',$FullMemberName))]">
			<H3>Méthodes : </H3>

			<TABLE width="100%" border="0" cellspacing="0" cellpadding="0">
				<xsl:for-each select="//member[contains(@name,concat('M:',$FullMemberName))]">
					<TR>
						<TD width="35px"></TD>
						<TD>
							<H4>
								<xsl:choose>
									<xsl:when test="contains(@name, '#ctor')">
										Constructeurs :
										<xsl:value-of select="$MemberName"/>
										<xsl:value-of select="substring-after(@name, '#ctor')"/>
										<hr/>
									</xsl:when>
									<xsl:otherwise>
										<xsl:value-of select="substring-after(@name, concat('M:',$FullMemberName,'.'))"/>
										<hr/>
									</xsl:otherwise>
								</xsl:choose>
							</H4>

							<xsl:apply-templates select="summary"/>

							<xsl:if test="count(returns)!=0">
								<xsl:apply-templates select="returns"/>
							</xsl:if>

							<xsl:if test="count(param)!=0">
								<H4>
									<I>Paramètres : </I>
								</H4>
								<xsl:apply-templates select="param"/>
							</xsl:if>

							<xsl:if test="count(exception)!=0">
								<H4>
									<I>Exceptions : </I>
								</H4>
								<xsl:apply-templates select="exception"/>
							</xsl:if>

							<xsl:if test="count(example)!=0">
								<H4>
									<I>Exemple :</I>
								</H4>
								<xsl:apply-templates select="example"/>
							</xsl:if>

						</TD>
					</TR>

				</xsl:for-each>
			</TABLE>

		</xsl:if>
	</xsl:template>

	<xsl:template match="c">
		<CODE>
			<xsl:apply-templates />
		</CODE>
	</xsl:template>

	<xsl:template match="code">
		<PRE>
			<xsl:apply-templates />
		</PRE>
	</xsl:template>

	<xsl:template match="example">
		<P>
			<STRONG>Exemple: </STRONG>
			<xsl:apply-templates />
		</P>
	</xsl:template>

	<xsl:template match="exception">
		<P>
			<STRONG>
				<xsl:value-of select="substring-after(@cref,'T:')"/>:
			</STRONG>
			<xsl:apply-templates />
		</P>
	</xsl:template>

	<xsl:template match="include">
		<A HREF="{@file}">Fichiers externes : </A>
	</xsl:template>

	<xsl:template match="para">
		<P>
			<xsl:apply-templates />
		</P>
	</xsl:template>

	<xsl:template match="param">
		<P>
			<STRONG>
				<xsl:value-of select="@name"/>:
			</STRONG>
			<xsl:apply-templates />
		</P>
	</xsl:template>

	<xsl:template match="paramref">
		<EM>
			<xsl:value-of select="@name" />
		</EM>
	</xsl:template>

	<xsl:template match="permission">
		<P>
			<STRONG>Permissions : </STRONG>
			<EM>
				<xsl:value-of select="@cref" />
			</EM>
			<xsl:apply-templates />
		</P>
	</xsl:template>

	<xsl:template match="remarks">
		<P>
			<xsl:apply-templates />
		</P>
	</xsl:template>

	<xsl:template match="returns">
		<P>
			<STRONG>Valeur de retour : </STRONG>
			<xsl:apply-templates />
		</P>
	</xsl:template>

	<xsl:template match="see">
		<EM>
			Voir : <xsl:value-of select="@cref" />
		</EM>
	</xsl:template>

	<xsl:template match="seealso">
		<EM>
			Voir aussi : <xsl:value-of select="@cref" />
		</EM>
	</xsl:template>

	<xsl:template match="summary">
		<P>
			<xsl:apply-templates />
		</P>
	</xsl:template>

</xsl:stylesheet>
