
using Soccer.Shared.FutDb;
using System.Collections.Generic;

namespace Soccer.Shared
{
	public class PageElement
	{
		public bool IsActive { get; set; }
		public int Counter { get; set; }
	}

	public class PageElementes
	{
		public static List<PageElement> GetPageElements(PageFutModel request)
		{
			List<PageElement> pages = new List<PageElement>();
			int firstPage = 1;
			// Aggiungi pagina precedente
			if (request.Page > 1)
				firstPage = request.Page - 1;
			pages.Add(AddElement(firstPage, request));
			pages.Add(AddElement(++firstPage, request));

			// Aggiungi pagina successiva
			if (request.PageTotal - request.Page > 1)
				pages.Add(AddElement(++firstPage, request));
			
			return pages;
		}

		private static PageElement AddElement(int firstPage, PageFutModel request)
		{
			return new PageElement
			{
				Counter = firstPage,
				IsActive = firstPage == request.Page
			};
		}
	}
}
