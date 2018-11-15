<?xml version="1.0" encoding="utf-8" ?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
	<xsl:template match="/ArrayOfOrderDetatils">
		<html>
			<head>
				<title>Order</title>
			</head>
			<body>
				<ul>
					<xsl:for-each select="OrderDetatils">
						<li>
              <p>订单号码</p>
							<xsl:value-of select="OrderNumber" />
              <p>订单数量</p>
              <xsl:value-of select="OrderQuantity" />
              <p>产品名字</p>
              <xsl:value-of select="ProductName" />
              <p>客户名称</p>
              <xsl:value-of select="Client" />
						</li>
					</xsl:for-each>
				</ul>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>
