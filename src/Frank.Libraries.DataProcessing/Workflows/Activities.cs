using System.Collections;

namespace Frank.Libraries.DataProcessing.Workflows;

public class Activities : IEnumerable<IActivity>
{
    private readonly OrderedDictionary<IActivity> _activities = new();

    public IEnumerator<IActivity> GetEnumerator() => _activities.Values.Order(new ActivityComparer())
                                                                .GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public void Add(IActivity activity)
    {
        if (!_activities.Any())
        {
            activity.Order = 1;
            _activities.Add(activity.Order.Value, activity);
        }
        else if (activity is { Order: { } })
        {
            if (!_activities.ContainsKey(activity.Order.Value))
            {
                _activities.Add(activity.Order.Value, activity);
            }
        }
        else
        {
            var lastKey = _activities.Keys.Order()
                                     .Last();
            activity.Order = lastKey + 1;
            _activities.Add(activity.Order.Value, activity);
        }
    }
}