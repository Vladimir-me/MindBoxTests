SELECT Articles.Name, Tags.Name
FROM Articles
LEFT OUTER JOIN Articles_Tags
ON Articles.Id = Articles_Tags.ArticleId
LEFT OUTER JOIN Tags
ON Articles_Tags.TagId = Tags.Id